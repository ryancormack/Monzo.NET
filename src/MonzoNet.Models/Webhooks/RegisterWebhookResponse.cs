using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MonzoNet.Models.Webhooks
{
    public class RegisterWebhookResponse
    {
        /// <summary>
        /// The Webhook
        /// </summary>
        [JsonProperty(PropertyName = "webhook")]
        public Webhook Webhook { get; set; }
    }
}
