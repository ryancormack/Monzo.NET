using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MonzoNet.Models.Webhooks
{
    public class ListWebhooksResponse
    {
        /// <summary>
        /// A collection of Webhooks
        /// </summary>
        [JsonPropertyName("webhooks")]
        public IEnumerable<Webhook> Webhooks { get; set; }
    }
}
