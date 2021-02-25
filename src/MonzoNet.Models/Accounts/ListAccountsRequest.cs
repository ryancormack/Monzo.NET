using Refit;

namespace MonzoNet.Models.Accounts
{
    public class ListAccountsRequest
    {
        /// <summary>
        /// An <see cref="MonzoNet.Models.Accounts.AccountType"/>
        /// </summary>
        [AliasAs("account_type")]
        public string AccountType { get; set; }
    }
}
