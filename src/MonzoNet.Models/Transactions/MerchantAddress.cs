using System.Text.Json.Serialization;

namespace MonzoNet.Models.Transactions
{
    public class MerchantAddress
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("country")]
        public string CountryCode { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }
    }
}
