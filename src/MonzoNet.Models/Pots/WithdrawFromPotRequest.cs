using System;
using System.Collections.Generic;
using System.Text;
using Refit;

namespace MonzoNet.Models.Pots
{
    public class WithdrawFromPotRequest
    {
        public WithdrawFromPotRequest()
        {

        }

        /// <summary>
        /// The id of the account to deposit into.
        /// </summary>
        [AliasAs("destination_account_id")]
        public string DestinationAccountId { get; }

        /// <summary>
        /// The amount to deposit, as a 64bit integer in minor units of the currency,
        /// eg. pennies for GBP, or cents for EUR and USD.
        /// </summary>
        [AliasAs("amount")]
        public long Amount { get; }

        /// <summary>
        /// A unique string used to de-duplicate deposits.
        /// Ensure this remains static between retries to ensure only one withdrawal is created.
        /// </summary>
        [AliasAs("dedupe_id")]
        public string DedupeId { get; }
    }
}
