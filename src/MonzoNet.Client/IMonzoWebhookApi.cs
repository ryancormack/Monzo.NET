using System.Threading.Tasks;
using MonzoNet.Models.Webhooks;
using Refit;

namespace MonzoNet.Client
{
    public interface IMonzoWebhookApi
    {
        [Get("/webhooks")]
        Task<ListWebhooksResponse> ListWebhooksAsync(ListWebhooksRequest request,
            [Header("Authorization")] string bearerToken);

        [Post("/webhooks")]
        Task<RegisterWebhookResponse> RegisterWebhookAsync(
            [Body(BodySerializationMethod.UrlEncoded)] RegisterWebhookRequest request,
            [Header("Authorization")] string bearerToken);

        [Delete("/webhooks/{webhook_id}")]
        Task DeleteWebhookAsync(
            [AliasAs("webhook_id")] string webhookId,
            [Header("Authorization")] string bearerToken);
    }
}
