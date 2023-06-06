using System;
using System.Threading;
using BackEnd;
using BackEnd.Game;
using BackEnd.GlobalSupport;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BackendMemberExtensions
    {
        public static UniTask<BackendReturnObject> AuthorizeFederationAsync(this BackendMember self, string accessToken, FederationType type)
            => Asynchronizer.Make(self.AuthorizeFederation, accessToken, type);
        public static UniTask<BackendReturnObject> AuthorizeFederationAsync(this BackendMember self, string accessToken, FederationType type, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.AuthorizeFederation, accessToken, type, cancellationToken);
        public static UniTask<BackendReturnObject> AuthorizeFederationAsync(this BackendMember self, string accessToken, FederationType type, string etc)
            => Asynchronizer.Make(self.AuthorizeFederation, accessToken, type, etc);
        public static UniTask<BackendReturnObject> AuthorizeFederationAsync(this BackendMember self, string accessToken, FederationType type, string etc, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.AuthorizeFederation, accessToken, type, etc, cancellationToken);

        public static UniTask<BackendReturnObject> ChangeCustomToFederationAsync(this BackendMember self, string federationToken, FederationType type)
            => Asynchronizer.Make(self.ChangeCustomToFederation, federationToken, type);
        public static UniTask<BackendReturnObject> ChangeCustomToFederationAsync(this BackendMember self, string federationToken, FederationType type, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ChangeCustomToFederation, federationToken, type, cancellationToken);

        public static UniTask<BackendReturnObject> CheckNicknameDuplicationAsync(this BackendMember self, string nickname)
            => Asynchronizer.Make(self.CheckNicknameDuplication, nickname);
        public static UniTask<BackendReturnObject> CheckNicknameDuplicationAsync(this BackendMember self, string nickname, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.CheckNicknameDuplication, nickname, cancellationToken);

        public static UniTask<BackendReturnObject> CheckUserInBackendAsync(this BackendMember self, string federationToken, FederationType type)
            => Asynchronizer.Make(self.CheckUserInBackend, federationToken, type);
        public static UniTask<BackendReturnObject> CheckUserInBackendAsync(this BackendMember self, string federationToken, FederationType type, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.CheckUserInBackend, federationToken, type, cancellationToken);

        public static UniTask<BackendReturnObject> ConfirmCustomPasswordAsync(this BackendMember self, string CustomGamerPassword)
            => Asynchronizer.Make(self.ConfirmCustomPassword, CustomGamerPassword);
        public static UniTask<BackendReturnObject> ConfirmCustomPasswordAsync(this BackendMember self, string CustomGamerPassword, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ConfirmCustomPassword, CustomGamerPassword, cancellationToken);

        public static UniTask<BackendReturnObject> CreateNicknameAsync(this BackendMember self, string nickname)
            => Asynchronizer.Make(self.CreateNickname, nickname);
        public static UniTask<BackendReturnObject> CreateNicknameAsync(this BackendMember self, string nickname, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.CreateNickname, nickname, cancellationToken);

        public static UniTask<BackendReturnObject> CustomLoginAsync(this BackendMember self, string id, string password)
            => Asynchronizer.Make(self.CustomLogin, id, password);
        public static UniTask<BackendReturnObject> CustomLoginAsync(this BackendMember self, string id, string password, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.CustomLogin, id, password, cancellationToken);
        public static UniTask<BackendReturnObject> CustomLoginAsync(this BackendMember self, string id, string password, string etc)
            => Asynchronizer.Make(self.CustomLogin, id, password, etc);
        public static UniTask<BackendReturnObject> CustomLoginAsync(this BackendMember self, string id, string password, string etc, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.CustomLogin, id, password, etc, cancellationToken);

        public static UniTask<BackendReturnObject> CustomSignUpAsync(this BackendMember self, string id, string password)
            => Asynchronizer.Make(self.CustomSignUp, id, password);
        public static UniTask<BackendReturnObject> CustomSignUpAsync(this BackendMember self, string id, string password, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.CustomSignUp, id, password, cancellationToken);
        public static UniTask<BackendReturnObject> CustomSignUpAsync(this BackendMember self, string id, string password, string etc)
            => Asynchronizer.Make(self.CustomSignUp, id, password, etc);
        public static UniTask<BackendReturnObject> CustomSignUpAsync(this BackendMember self, string id, string password, string etc, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.CustomSignUp, id, password, etc, cancellationToken);

        public static UniTask<BackendReturnObject> FindCustomIDAsync(this BackendMember self, string EmailAddress)
            => Asynchronizer.Make(self.FindCustomID, EmailAddress);
        public static UniTask<BackendReturnObject> FindCustomIDAsync(this BackendMember self, string EmailAddress, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.FindCustomID, EmailAddress, cancellationToken);

        public static UniTask<BackendReturnObject> GetCountryCodeByIndateAsync(this BackendMember self, string inDate)
            => Asynchronizer.Make(self.GetCountryCodeByIndate, inDate);
        public static UniTask<BackendReturnObject> GetCountryCodeByIndateAsync(this BackendMember self, string inDate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetCountryCodeByIndate, inDate, cancellationToken);

        public static UniTask<BackendReturnObject> GetMyCountryCodeAsync(this BackendMember self)
            => Asynchronizer.Make(self.GetMyCountryCode);
        public static UniTask<BackendReturnObject> GetMyCountryCodeAsync(this BackendMember self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMyCountryCode, cancellationToken);

        public static UniTask<BackendReturnObject> GetUserInfoAsync(this BackendMember self)
            => Asynchronizer.Make(self.GetUserInfo);
        public static UniTask<BackendReturnObject> GetUserInfoAsync(this BackendMember self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetUserInfo, cancellationToken);

        public static UniTask<BackendReturnObject> GuestLoginAsync(this BackendMember self, string etc)
            => Asynchronizer.Make(self.GuestLogin, etc);
        public static UniTask<BackendReturnObject> GuestLoginAsync(this BackendMember self, string etc, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GuestLogin, etc, cancellationToken);
        public static UniTask<BackendReturnObject> GuestLoginAsync(this BackendMember self)
            => Asynchronizer.Make(self.GuestLogin);
        public static UniTask<BackendReturnObject> GuestLoginAsync(this BackendMember self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GuestLogin, cancellationToken);

        public static UniTask<BackendReturnObject> IsAccessTokenAliveAsync(this BackendMember self)
            => Asynchronizer.Make(self.IsAccessTokenAlive);
        public static UniTask<BackendReturnObject> IsAccessTokenAliveAsync(this BackendMember self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.IsAccessTokenAlive, cancellationToken);

        public static UniTask<BackendReturnObject> LoginWithTheBackendTokenAsync(this BackendMember self)
            => Asynchronizer.Make(self.LoginWithTheBackendToken);
        public static UniTask<BackendReturnObject> LoginWithTheBackendTokenAsync(this BackendMember self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.LoginWithTheBackendToken, cancellationToken);

        public static UniTask<BackendReturnObject> LogoutAsync(this BackendMember self)
            => Asynchronizer.Make(self.Logout);
        public static UniTask<BackendReturnObject> LogoutAsync(this BackendMember self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Logout, cancellationToken);

        public static UniTask<BackendReturnObject> RefreshTheBackendTokenAsync(this BackendMember self)
            => Asynchronizer.Make(self.RefreshTheBackendToken);
        public static UniTask<BackendReturnObject> RefreshTheBackendTokenAsync(this BackendMember self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.RefreshTheBackendToken, cancellationToken);

        public static UniTask<BackendReturnObject> ResetPasswordAsync(this BackendMember self, string CustomGamerId, string EmailAddress)
            => Asynchronizer.Make(self.ResetPassword, CustomGamerId, EmailAddress);
        public static UniTask<BackendReturnObject> ResetPasswordAsync(this BackendMember self, string CustomGamerId, string EmailAddress, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ResetPassword, CustomGamerId, EmailAddress, cancellationToken);

        [Obsolete("SignOut is deprecated, please use WithdrawAccount instead.(This function will be removed in SDK-6.0.0 version.)")]
        public static UniTask<BackendReturnObject> SignOutAsync(this BackendMember self)
            => Asynchronizer.Make(self.SignOut);
        [Obsolete("SignOut is deprecated, please use WithdrawAccount instead.(This function will be removed in SDK-6.0.0 version.)")]
        public static UniTask<BackendReturnObject> SignOutAsync(this BackendMember self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.SignOut, cancellationToken);
        [Obsolete("SignOut is deprecated, please use WithdrawAccount instead.(This function will be removed in SDK-6.0.0 version.)")]
        public static UniTask<BackendReturnObject> SignOutAsync(this BackendMember self, string reason)
            => Asynchronizer.Make(self.SignOut, reason);
        [Obsolete("SignOut is deprecated, please use WithdrawAccount instead.(This function will be removed in SDK-6.0.0 version.)")]
        public static UniTask<BackendReturnObject> SignOutAsync(this BackendMember self, string reason, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.SignOut, reason, cancellationToken);

        public static UniTask<BackendReturnObject> UpdateCountryCodeAsync(this BackendMember self, CountryCode code)
            => Asynchronizer.Make(self.UpdateCountryCode, code);
        public static UniTask<BackendReturnObject> UpdateCountryCodeAsync(this BackendMember self, CountryCode code, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UpdateCountryCode, code, cancellationToken);

        public static UniTask<BackendReturnObject> UpdateCustomEmailAsync(this BackendMember self, string EmailAddress)
            => Asynchronizer.Make(self.UpdateCustomEmail, EmailAddress);
        public static UniTask<BackendReturnObject> UpdateCustomEmailAsync(this BackendMember self, string EmailAddress, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UpdateCustomEmail, EmailAddress, cancellationToken);

        public static UniTask<BackendReturnObject> UpdateFederationEmailAsync(this BackendMember self, string federationToken, FederationType type)
            => Asynchronizer.Make(self.UpdateFederationEmail, federationToken, type);
        public static UniTask<BackendReturnObject> UpdateFederationEmailAsync(this BackendMember self, string federationToken, FederationType type, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UpdateFederationEmail, federationToken, type, cancellationToken);

        public static UniTask<BackendReturnObject> UpdateNicknameAsync(this BackendMember self, string nickname)
            => Asynchronizer.Make(self.UpdateNickname, nickname);
        public static UniTask<BackendReturnObject> UpdateNicknameAsync(this BackendMember self, string nickname, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UpdateNickname, nickname, cancellationToken);

        public static UniTask<BackendReturnObject> UpdatePasswordAsync(this BackendMember self, string OldPassword, string NewPassword)
            => Asynchronizer.Make(self.UpdatePassword, OldPassword, NewPassword);
        public static UniTask<BackendReturnObject> UpdatePasswordAsync(this BackendMember self, string OldPassword, string NewPassword, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UpdatePassword, OldPassword, NewPassword, cancellationToken);

        public static UniTask<BackendReturnObject> WithdrawAccountAsync(this BackendMember self)
            => Asynchronizer.Make(self.WithdrawAccount);
        public static UniTask<BackendReturnObject> WithdrawAccountAsync(this BackendMember self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.WithdrawAccount, cancellationToken);
        public static UniTask<BackendReturnObject> WithdrawAccountAsync(this BackendMember self, int graceHours)
            => Asynchronizer.Make(self.WithdrawAccount, graceHours);
        public static UniTask<BackendReturnObject> WithdrawAccountAsync(this BackendMember self, int graceHours, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.WithdrawAccount, graceHours, cancellationToken);
    }
}
