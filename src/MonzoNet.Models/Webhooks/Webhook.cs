using System;
using System.Text.Json.Serialization;

namespace MonzoNet.Models.Webhooks
{
    public class Webhook
    {
        /// <summary>
        /// The Account Id
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// The Webhook Id
        /// </summary>
        [JsonPropertyName("id")]
        public string WebhookId { get; set; }

        /// <summary>
        /// The Webhook Url
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}
