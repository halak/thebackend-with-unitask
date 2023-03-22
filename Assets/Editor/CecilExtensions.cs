using System.Linq;
using System.Text.RegularExpressions;
using Mono.Cecil;

namespace Halak.Editor
{
    internal static class CecilExtensions
    {
        private static readonly Regex genericMarkRegex = new Regex(@"`\d+", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);

        public static TypeDefinition GetType<T>(this AssemblyDefinition assembly)
        {
            var typeFromMainModule = GetType<T>(assembly.MainModule);
            if (typeFromMainModule != null)
                return typeFromMainModule;

            foreach (var module in assembly.Modules)
            {
                var type = GetType<T>(module);
                if (type != null)
                    return type;
            }

            return null;
        }

        public static TypeDefinition GetType<T>(this ModuleDefinition module)
            => module.GetType(typeof(T).Namespace, typeof(T).Name);

        public static string GetReadableName(this TypeReference type)
        {
            switch (type.MetadataType)
            {
                case MetadataType.Void: return "void";
                case MetadataType.Boolean: return "bool";
                case MetadataType.Char: return "char";
                case MetadataType.SByte: return "sbyte";
                case MetadataType.Byte: return "byte";
                case MetadataType.Int16: return "short";
                case MetadataType.UInt16: return "ushort";
                case MetadataType.Int32: return "int";
                case MetadataType.UInt32: return "uint";
                case MetadataType.Int64: return "long";
                case MetadataType.UInt64: return "ulong";
                case MetadataType.Single: return "float";
                case MetadataType.Double: return "double";
                case MetadataType.String: return "string";
                case MetadataType.Array: return $"{GetReadableName(type.GetElementType())}[]";
                case MetadataType.GenericInstance:
                    if (type is GenericInstanceType genericInstanceType)
                    {
                        var name = genericMarkRegex.Replace(type.Name, string.Empty);
                        return $"{name}<{string.Join(", ", genericInstanceType.GenericArguments.Select((arg) => GetReadableName(arg)))}>";
                    }
                    break;
            }

            return type.Name;
        }
    }
}
