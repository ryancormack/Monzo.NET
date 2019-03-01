using System.Collections.Generic;
using Newtonsoft.Json;

namespace MonzoNet.Models.Transactions
{
    public class ListTransactionsResponse
    {
        [JsonProperty(PropertyName = "transactions")]
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
