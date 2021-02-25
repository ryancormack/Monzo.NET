using Refit;

namespace MonzoNet.Models.Balance
{
    public class BalanceRequest
    {
        public BalanceRequest(string accountId)
        {
            AccountId = accountId;
        }
        /// <summary>
        /// The id of the account.
        /// </summary>
        [AliasAs("account_id")]
        public string AccountId { get;}
    }
}
