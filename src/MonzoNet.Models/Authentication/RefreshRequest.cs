using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MonzoNet.Models.Authentication
{
    public class RefreshRequest
    {
        /// <summary>
        /// The type of Grant you are requesting. This is set to refresh_token
        /// </summary>
        public string GrantType => "refresh_token";

        /// <summary>
        /// Your client ID.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Your client secret.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// The refresh token received along with the original access token.
        /// </summary>
        public string RefreshToken { get; set; }
    }
}
