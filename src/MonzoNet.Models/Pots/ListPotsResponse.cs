using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MonzoNet.Models.Pots
{
    public class ListPotsResponse
    {
        /// <summary>
        /// A collection of pots
        /// </summary>
        [JsonPropertyName("pots")]
        public IEnumerable<Pot> Pots { get; set; }
    }
}
