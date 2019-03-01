using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MonzoNet.Models.Accounts
{
    public class ListAccountsResponse
    {
        /// <summary>
        /// A collection of pots
        /// </summary>
        [JsonProperty(PropertyName = "accounts")]
        public IEnumerable<Account> Accounts { get; set; }
    }
}
