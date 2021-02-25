using System.Text.Json.Serialization;

namespace MonzoNet.Models.Transactions
{
    public class AnnotateTransactionResponse
    {
        [JsonPropertyName("transaction")]
        public Transaction Transaction { get; set; }
    }
}
