using System.Text.Json.Serialization;

namespace MonzoNet.Models.Transactions
{
    public class RetrieveTransactionResponse
    {
        [JsonPropertyName("transaction")]
        public Transaction Transaction { get; set; }
    }
}
