using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Mono.Cecil;
using UnityEditor;

namespace Halak.Editor
{
    public static class SourceCodeGenerator
    {
        [MenuItem("Backend with UniTask/Generate Source Code")]
        internal static void Invoke()
        {
            var backendAssemblyPath = "Packages/BackendWithUniTask/Plugins/Backend.dll";
            var backendAssembly = AssemblyDefinition.ReadAssembly(backendAssemblyPath);

            Generate(backendAssembly.GetType<BackEnd.Util.BackendUtils>());
            Generate(backendAssembly.GetType<BackEnd.Game.BackendMember>());
            Generate(backendAssembly.GetType<BackEnd.Game.GameInfo.BGameData>());
            Generate(backendAssembly.GetType<BackEnd.Game.BNotice>());
            Generate(backendAssembly.GetType<BackEnd.Game.BPolicy>());
            Generate(backendAssembly.GetType<BackEnd.Game.BEvent>());
            Generate(backendAssembly.GetType<BackEnd.Game.BQuestion>());
            Generate(backendAssembly.GetType<BackEnd.Game.BCoupon>());
            Generate(backendAssembly.GetType<BackEnd.Game.BProbability>());
            Generate(backendAssembly.GetType<BackEnd.Game.BChart>());
            Generate(backendAssembly.GetType<BackEnd.Game.Rank.UnionRank>());
            Generate(backendAssembly.GetType<BackEnd.Social.BSocial>());
            Generate(backendAssembly.GetType<BackEnd.Game.Guild.BGuild>());
            Generate(backendAssembly.GetType<BackEnd.Game.BMessage>());
            Generate(backendAssembly.GetType<BackEnd.Game.BFriend>());
            Generate(backendAssembly.GetType<BackEnd.Game.Payment.BReceipt>());
            Generate(backendAssembly.GetType<BackEnd.Game.Payment.BTbc>());
            Generate(backendAssembly.GetType<BackEnd.Game.BFunction>());
            Generate(backendAssembly.GetType<BackEnd.Game.BLog>());
            Generate(backendAssembly.GetType<BackEnd.Game.BUpgradePost>());
            Generate(backendAssembly.GetType<BackEnd.Game.BRandomInfo>());
            Generate(backendAssembly.GetType<BackEnd.Game.BaseErrorHandler>());
            Generate(backendAssembly.GetType<BackEnd.Util.BRateCounter>());
            Generate(backendAssembly.GetType<BackEnd.NativeInstance.iOSInstance>());
            Generate(backendAssembly.GetType<BackEnd.NativeInstance.AndroidInstance>());
            Generate(backendAssembly.GetType<BackEnd.RealTime.GameChat>());
            Generate(backendAssembly.GetType<BackEnd.RealTime.GameMatch>());
            Generate(backendAssembly.GetType<BackEnd.RealTime.RTNotification>());
        }

        private static void Generate(TypeDefinition type)
        {
            Generate(type, $"Packages/BackendWithUniTask/Runtime/{type.Name}Extensions.cs");
        }

        private static void Generate(TypeDefinition type, string outputPath)
        {
            var tab = new string(' ', 4);

            using var stream = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None);
            using var writer = new StreamWriter(stream);

            writer.WriteLine($"//");
            writer.WriteLine($"//");
            writer.WriteLine($"//");

            var namespaces = new[] { type.Namespace, "Cysharp.Threading.Tasks", }
                .Concat(GetCallbackMethods(type).SelectMany((method) => GetReferences(method).Select((type) => type.Namespace)))
                .Where((@namespace) => @namespace.Length > 0)
                .Distinct(StringComparer.Ordinal)
                .OrderBy((@namespace) => GetNamespaceScore(@namespace));

            foreach (var @namespace in namespaces)
                writer.WriteLine($"using {@namespace};");

            writer.WriteLine($"");
            writer.WriteLine($"namespace Halak");
            writer.WriteLine($"{{");
            writer.WriteLine($"{tab}public static class {Path.GetFileNameWithoutExtension(outputPath)}");
            writer.WriteLine($"{tab}{{");

            var methodGroups = GetCallbackMethods(type)
                .GroupBy(it => it.Name)
                .OrderBy(it => it.Key, StringComparer.Ordinal)
                .ToArray();

            for (var i = 0; i < methodGroups.Length; i++)
            {
                foreach (var method in methodGroups[i])
                {
                    var customAttributes = method.CustomAttributes
                        .Where((it) => it.AttributeType.FullName != typeof(System.Runtime.CompilerServices.AsyncStateMachineAttribute).FullName);
                    foreach (var customAttribute in customAttributes)
                    {
                        var attributeName = customAttribute.AttributeType.Name;
                        if (attributeName.EndsWith(nameof(Attribute), StringComparison.Ordinal))
                            attributeName = attributeName.Substring(0, attributeName.Length - nameof(Attribute).Length);

                        var constructorArguments = customAttribute.ConstructorArguments.Select((arg) => Literalize(arg.Value));
                        writer.WriteLine($"{tab}{tab}[{attributeName}({string.Join(", ", constructorArguments)})]");
                    }

                    var self = "self";
                    var parameters = new[] { $"this {type.Name} {self}" }.Concat(method.Parameters
                        .Select((parameter) => $"{parameter.ParameterType.GetReadableName()} {parameter.Name}")
                        .Take(method.Parameters.Count - 1));
                    var args = new[] { $"{self}.{method.Name}" }.Concat(method.Parameters
                        .Select((parameter) => parameter.Name)
                        .Take(method.Parameters.Count - 1));
                    var returnType = GetCallbackReturnType(method);

                    writer.WriteLine($"{tab}{tab}public static UniTask<{returnType.GetReadableName()}> {method.Name}Async({string.Join(", ", parameters)})");
                    writer.WriteLine($"{tab}{tab}{tab}=> Asynchronizer.Make({string.Join(", ", args)});");
                }

                if (i < methodGroups.Length - 1)
                    writer.WriteLine();
            }

            writer.WriteLine($"{tab}}}");
            writer.WriteLine($"}}");
        }

        private static IEnumerable<MethodDefinition> GetCallbackMethods(TypeDefinition type)
        {
            return type.Methods.Where((method) => IsCallbackMethod(method));

            static bool IsCallbackMethod(MethodDefinition method)
            {
                if (method.IsPublic == false)
                    return false;
                if (method.IsStatic)
                    return false;
                if (method.Parameters.Count == 0)
                    return false;

                if (method.Parameters[method.Parameters.Count - 1].ParameterType.Name == nameof(BackEnd.Backend.BackendCallback))
                    return true;
                else
                    return false;
            }
        }

        private static IEnumerable<TypeReference> GetReferences(MethodDefinition method)
        {
            var attributes = method.CustomAttributes
                .Where((attribute) => attribute.AttributeType.FullName != typeof(System.Runtime.CompilerServices.AsyncStateMachineAttribute).FullName)
                .Select((attribute) => attribute.AttributeType);
            var parameters = method.Parameters.Select((parameter) => parameter.ParameterType);

            return attributes.Concat(parameters).Append(GetCallbackReturnType(method));
        }

        private static TypeReference GetCallbackReturnType(MethodDefinition method)
        {
            if (method == null)
                throw new ArgumentNullException(nameof(method));
            if (method.Parameters.Count == 0)
                throw new ArgumentException($"{nameof(method)} must have a callback parameter.", nameof(method));

            var callbackParameter = method.Parameters[method.Parameters.Count - 1];
            var callbackParameterType = callbackParameter.ParameterType.Resolve();
            var invokeMethod = callbackParameterType.Methods.First((method) => method.Name == nameof(Action<object>.Invoke));
            return invokeMethod.Parameters[0].ParameterType;
        }

        private static ValueTuple<int, string> GetNamespaceScore(string @namespace)
        {
            if (@namespace == "System")
                return ValueTuple.Create(0, @namespace);
            else if (@namespace.StartsWith("System."))
                return ValueTuple.Create(1, @namespace);
            else
                return ValueTuple.Create(2, @namespace);
        }

        private static string Literalize(object value)
        {
            if (value is null)
                return "null";

            switch (Type.GetTypeCode(value.GetType()))
            {
                case TypeCode.Empty:
                    return "null";
                case TypeCode.DBNull:
                    return "null";
                case TypeCode.Boolean:
                    return ((bool)value) ? "true" : "false";
                case TypeCode.SByte:
                    return $"{value}";
                case TypeCode.Byte:
                    return $"{value}";
                case TypeCode.Char:
                    return $"'{(char)value}'";
                case TypeCode.Int16:
                    return $"{value}";
                case TypeCode.UInt16:
                    return $"{value}";
                case TypeCode.Int32:
                    return $"{value}";
                case TypeCode.UInt32:
                    return $"{value}U";
                case TypeCode.Int64:
                    return $"{value}L";
                case TypeCode.UInt64:
                    return $"{value}UL";
                case TypeCode.Single:
                    return $"{value}f";
                case TypeCode.Double:
                    return $"{value}";
                case TypeCode.Decimal:
                    return $"{value}m";
                case TypeCode.String:
                    return $"\"{value}\"";
            }

            throw new ArgumentException($"Failed to literalize: {value}", nameof(value));
        }
    }
}
