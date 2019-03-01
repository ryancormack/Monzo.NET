using System.Threading.Tasks;
using MonzoNet.Models.Transactions;
using Refit;

namespace MonzoNet.Client
{
    public interface IMonzoTransactionApi
    {
        [Get("/transactions/{transaction_id}")]
        Task<RetrieveTransactionResponse> RetrieveTransaction(
            [AliasAs("transaction_id")] string transactionId,
            [Header("Authorization")] string bearerToken);

        [Get("/transactions")]
        Task<ListTransactionsResponse> ListTransactions(
            [AliasAs("account_id")] string accountId,
            [Header("Authorization")] string bearerToken);

        [Patch("/transactions/{transaction_id}")]
        Task<AnnotateTransactionResponse> AnnotateTransaction(
            [AliasAs("transaction_id")] string transactionId,
            [Header("Authorization")] string bearerToken);
    }
}
