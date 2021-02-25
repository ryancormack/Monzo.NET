using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MonzoNet.Models.Accounts
{
    public class ListAccountsResponse
    {
        /// <summary>
        /// A collection of pots
        /// </summary>
        [JsonPropertyName("accounts")]
        public IEnumerable<Account> Accounts { get; set; }
    }
}
