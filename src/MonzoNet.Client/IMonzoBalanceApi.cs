using System.Threading.Tasks;
using MonzoNet.Models.Balance;
using Refit;

namespace MonzoNet.Client
{
    public interface IMonzoBalanceApi
    {
        [Get("/balance")]
        Task<BalanceResponse> ReadBalanceAsync(BalanceRequest request,
            [Header("Authorization")] string bearerToken);
    }
}
