using System.Text.Json.Serialization;

namespace MonzoNet.Models.Webhooks
{
    public class RegisterWebhookResponse
    {
        /// <summary>
        /// The Webhook
        /// </summary>
        [JsonPropertyName("webhook")]
        public Webhook Webhook { get; set; }
    }
}
