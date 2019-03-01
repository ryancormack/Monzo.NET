using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MonzoNet.Models.Authentication
{
    public class WhoAmIResponse
    {
        /// <summary>
        /// Is the currenct token authenticated.
        /// </summary>
        [JsonProperty(PropertyName = "authenticated")]
        public bool Authenticated { get; set; }

        /// <summary>
        /// The client id the current token belongs to
        /// </summary>
        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// The user id the current token belongs to
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }
    }
}
