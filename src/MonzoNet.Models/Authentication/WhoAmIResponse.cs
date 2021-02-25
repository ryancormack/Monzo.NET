using System.Text.Json.Serialization;

namespace MonzoNet.Models.Authentication
{
    public class WhoAmIResponse
    {
        /// <summary>
        /// Is the currenct token authenticated.
        /// </summary>
        [JsonPropertyName("authenticated")]
        public bool Authenticated { get; set; }

        /// <summary>
        /// The client id the current token belongs to
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// The user id the current token belongs to
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
