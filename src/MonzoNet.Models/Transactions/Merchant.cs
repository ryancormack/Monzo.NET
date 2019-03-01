using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MonzoNet.Models.Transactions
{
    public class Merchant
    {
        [JsonProperty(PropertyName = "address")]
        public MerchantAddress MerchantAddress { get; set; }

        [JsonProperty(PropertyName = "created")]
        public DateTime CreatedUtc { get; set; }

        [JsonProperty(PropertyName = "group_id")]
        public string GroupId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "logo")]
        public string LogoUrl { get; set; }

        [JsonProperty(PropertyName = "emoji")]
        public string Emoji { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
    }
}
