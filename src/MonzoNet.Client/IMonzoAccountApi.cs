using System.Threading.Tasks;
using MonzoNet.Models.Accounts;
using Refit;

namespace MonzoNet.Client
{
    public interface IMonzoAccountApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="accountType">A string from the AccountType class</param>
        /// <returns></returns>
        [Get("/accounts")]
        Task<ListAccountsResponse> ListAccounts([Header("Authorization")] string bearerToken,
             ListAccountsRequest accountType = null);
    }
}
