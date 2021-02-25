using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MonzoNet.Models.Transactions
{
    public class Transaction
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("account_balance")]
        public long BalanceAfterTransaction { get; set; }

        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonPropertyName("created")]
        public DateTime CreatedUtc { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("decline_reason")]
        public string DeclinedReason { get; set; }

        [JsonPropertyName("is_load")]
        public bool IsLoad { get; set; }

        [JsonPropertyName("settled")]
        public DateTime? SettledUtc { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("merchant")]
        public string MerchantId { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("emoji")]
        public string Emoji { get; set; }
    }
}
