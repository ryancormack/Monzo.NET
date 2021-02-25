using System.Text.Json.Serialization;

namespace MonzoNet.Models.Authentication
{
    public class AuthorizationResponse
    {
        /// <summary>
        /// The Access Token to use for requests.
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Your client ID.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Number of seconds before the token expires.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// The OAuth refresh token to use to grant a new access token.
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// The OAuth 2 token type. This is set to Bearer
        /// </summary>
        public string TokenType => "Bearer";

        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
