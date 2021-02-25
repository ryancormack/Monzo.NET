using System;
using Refit;

namespace MonzoNet.Models.Webhooks
{
    public class RegisterWebhookRequest
    {
        public RegisterWebhookRequest(string accountId, Uri url)
        {
            AccountId = accountId;
            Url = url;
        }

        /// <summary>
        /// The id of the account to withdraw from.
        /// </summary>
        [AliasAs("account_id")]
        public string AccountId { get; }

        /// <summary>
        /// The id of the account to withdraw from.
        /// </summary>
        [AliasAs("url")]
        public Uri Url { get; }
    }
}
