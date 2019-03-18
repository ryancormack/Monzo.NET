using System;
using System.Collections.Generic;
using System.Text;
using MonzoNet.Models.Pots;
using Newtonsoft.Json;

namespace MonzoNet.Models.Webhooks
{
    public class ListWebhooksResponse
    {
        /// <summary>
        /// A collection of Webhooks
        /// </summary>
        [JsonProperty(PropertyName = "webhooks")]
        public IEnumerable<Webhook> Webhooks { get; set; }
    }
}
