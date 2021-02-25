using System;
using System.Text.Json.Serialization;

namespace MonzoNet.Models.Pots
{
    public class Pot
    {
        /// <summary>
        /// The Pot Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the pot
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The pot background image.
        /// </summary>
        [JsonPropertyName("style")]
        public string Style { get; set; }

        /// <summary>
        /// The currently available balance of the pot,
        /// as a 64bit integer in minor units of the currency,
        /// eg. pennies for GBP, or cents for EUR and USD.
        /// </summary>
        [JsonPropertyName("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// The ISO 4217 currency code.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The UTC time the pot was created
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime CreatedUtc { get; set; }

        /// <summary>
        /// The UTC time the pot was updated
        /// </summary>
        [JsonPropertyName("updated")]
        public DateTime UpdatedUtc { get; set; }

        /// <summary>
        /// Whether this pot is deleted. The API will be updated soon to not return deleted pots.
        /// </summary>
        [JsonPropertyName("deleted")]
        public bool Deleted { get; set; }
    }
}
