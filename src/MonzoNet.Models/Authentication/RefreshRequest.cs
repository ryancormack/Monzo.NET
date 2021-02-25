using System.Text.Json.Serialization;

namespace MonzoNet.Models.Authentication
{
    public class RefreshRequest
    {
        /// <summary>
        /// The type of Grant you are requesting. This is set to refresh_token
        /// </summary>
        [JsonPropertyName("grant_type")]
        public string GrantType => "refresh_token";

        /// <summary>
        /// Your client ID.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Your client secret.
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The refresh token received along with the original access token.
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
