using Newtonsoft.Json;

namespace MonzoNet.Models.Transactions
{
    public class RetrieveTransactionResponse
    {
        [JsonProperty(PropertyName = "transaction")]
        public Transaction Transaction { get; set; }
    }
}
