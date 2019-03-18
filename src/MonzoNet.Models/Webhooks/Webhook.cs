using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MonzoNet.Models.Webhooks
{
    public class Webhook
    {
        /// <summary>
        /// The Account Id
        /// </summary>
        [JsonProperty(PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// The Webhook Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string WebhookId { get; set; }

        /// <summary>
        /// The Webhook Url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public Uri Url { get; set; }
    }
}
