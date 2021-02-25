using Refit;

namespace MonzoNet.Models.Pots
{
    public class DepositPotRequest
    {
        public DepositPotRequest(string sourceAccountId, long amount, string dedupeId)
        {
            SourceAccountId = sourceAccountId;
            Amount = amount;
            DedupeId = dedupeId;
        }
        /// <summary>
        /// The id of the account to withdraw from.
        /// </summary>
        [AliasAs("source_account_id")]
        public string SourceAccountId { get; }

        /// <summary>
        /// The amount to deposit,
        /// as a 64bit integer in minor units of the currency,
        /// eg. pennies for GBP, or cents for EUR and USD.
        /// </summary>
        [AliasAs("amount")]
        public long Amount { get; }

        /// <summary>
        /// A unique string used to de-duplicate deposits.
        /// Ensure this remains static between retries to ensure only one deposit is created.
        /// </summary>
        [AliasAs("dedupe_id")]
        public string DedupeId { get; }
    }
}
