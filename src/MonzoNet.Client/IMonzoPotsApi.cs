using System.Threading.Tasks;
using MonzoNet.Models.Pots;
using Refit;

namespace MonzoNet.Client
{
    public interface IMonzoPotsApi
    {
        [Get("/pots")]
        Task<ListPotsResponse> ListPotsAsync([Header("Authorization")] string bearerToken);

        //Body(BodySerializationMethod.UrlEncoded)] serialises as a form
        [Put("/pots/{pot_id}/deposit")]
        Task<Pot> DepositIntoPotAsync([Body(BodySerializationMethod.UrlEncoded)] DepositPotRequest request,
            [AliasAs("pot_id")] string potId,
            [Header("Authorization")] string bearerToken);

        [Get("/pots/{pot_id}/withdraw")]
        Task<Pot> WithdrawFromPotAsync(WithdrawFromPotRequest request,
            [AliasAs("pot_id")] string potId,
            [Header("Authorization")] string bearerToken);
    }
}
