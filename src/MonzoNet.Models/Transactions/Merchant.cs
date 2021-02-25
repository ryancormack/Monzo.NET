using System;
using System.Text.Json.Serialization;

namespace MonzoNet.Models.Transactions
{
    public class Merchant
    {
        [JsonPropertyName("address")]
        public MerchantAddress MerchantAddress { get; set; }

        [JsonPropertyName("created")]
        public DateTime CreatedUtc { get; set; }

        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("logo")]
        public string LogoUrl { get; set; }

        [JsonPropertyName("emoji")]
        public string Emoji { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }
    }
}
