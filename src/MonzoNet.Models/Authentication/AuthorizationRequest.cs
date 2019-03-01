using Refit;

namespace MonzoNet.Models.Authentication
{
    public class AuthorizationRequest
    {
        /// <summary>
        /// The type of Grant you are requesting. This is set to authorization_code
        /// </summary>
        [AliasAs("grant_type")]
        public string GrantType => "authorization_code";

        /// <summary>
        /// Your client ID.
        /// </summary>
        [AliasAs("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Your client secret
        /// </summary>
        [AliasAs("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The URL in your app where users were sent after authorisation.
        /// </summary>
        [AliasAs("redirect_uri")]
        public string RedirectUri { get; set; }
        /// <summary>
        /// The authorization code you received when the user was redirected back to your app.
        /// </summary>
        [AliasAs("code")]
        public string Code { get; set; }
    }
}
