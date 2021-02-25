using Refit;

namespace MonzoNet.Models.Webhooks
{
    public class ListWebhooksRequest
    {
        public ListWebhooksRequest(string accountId)
        {
            AccountId = accountId;
        }
        /// <summary>
        /// The id of the account to withdraw from.
        /// </summary>
        [AliasAs("account_id")]
        public string AccountId { get; }
    }
}
