using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MonzoNet.Models.Transactions
{
    public class Transaction
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "account_balance")]
        public long BalanceAfterTransaction { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public long Amount { get; set; }

        [JsonProperty(PropertyName = "created")]
        public DateTime CreatedUtc { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "decline_reason")]
        public string DeclinedReason { get; set; }

        [JsonProperty(PropertyName = "is_load")]
        public bool IsLoad { get; set; }

        [JsonProperty(PropertyName = "settled")]
        public DateTime? SettledUtc { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "merchant")]
        public string MerchantId { get; set; }

        //[JsonProperty(PropertyName = "merchant")]
        //public Merchant Merchant { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "emoji")]
        public string Emoji { get; set; }
    }
}
