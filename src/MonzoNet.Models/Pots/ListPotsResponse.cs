using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MonzoNet.Models.Pots
{
    public class ListPotsResponse
    {
        /// <summary>
        /// A collection of pots
        /// </summary>
        [JsonProperty(PropertyName = "pots")]
        public IEnumerable<Pot> Pots { get; set; }
    }
}
