using System;
using System.Text.Json.Serialization;

namespace MonzoNet.Models.Accounts
{
    public class Account
    {
        /// <summary>
        /// The Account Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The Account description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The UTC time the pot was created
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime CreatedUtc { get; set; }
    }
}
