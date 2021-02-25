using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MonzoNet.Models.Transactions
{
    public class ListTransactionsResponse
    {
        [JsonPropertyName("transactions")]
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
