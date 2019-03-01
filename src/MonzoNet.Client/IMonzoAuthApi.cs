using System.Threading.Tasks;
using MonzoNet.Models.Authentication;
using Refit;

namespace MonzoNet.Client
{
    public interface IMonzoAuthApi
    {
        [Get("/ping/whoami")]
        Task<WhoAmIResponse> WhoAmI([Header("Authorization")] string bearerToken);

        [Post("/oauth2/token")]
        Task<AuthorizationResponse> RequestAccessToken(
            [Body(BodySerializationMethod.UrlEncoded)] AuthorizationRequest request);

        [Post("/oauth2/token")]
        Task<RefreshResponse> RefreshAccessToken(
            [Body(BodySerializationMethod.UrlEncoded)] RefreshRequest request);

        [Post("/oauth2/logout")]
        Task Logout([Header("Authorization")] string bearerToken);
    }
}
