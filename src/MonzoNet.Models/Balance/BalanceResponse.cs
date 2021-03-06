﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MonzoNet.Models.Balance
{
    public class BalanceResponse
    {
        /// <summary>
        /// The currently available balance of the account,
        /// as a 64bit integer in minor units of the currency,
        /// eg. pennies for GBP, or cents for EUR and USD.
        /// </summary>
        [JsonProperty(PropertyName = "balance")]
        public long Balance { get; set; }

        /// <summary>
        /// The sum of the currently available balance of the account
        /// and the combined total of all the user’s pots.
        /// </summary>
        [JsonProperty(PropertyName = "total_balance")]
        public long TotalBalance { get; set; }

        /// <summary>
        /// The ISO 4217 currency code.
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The amount spent from this account today (considered from approx 4am onwards),
        /// as a 64bit integer in minor units of the currency.
        /// </summary>
        [JsonProperty(PropertyName = "spend_today")]
        public long SpendToday { get; set; }
    }
}
