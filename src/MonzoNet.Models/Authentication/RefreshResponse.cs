﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MonzoNet.Models.Authentication
{
    public class RefreshResponse
    {
        /// <summary>
        /// The Access Token to use for requests.
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Your client ID.
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Number of seconds before the token expires.
        /// </summary>
        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// The OAuth refresh token to use to grant a new access token.
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// The OAuth 2 token type. This is set to Bearer
        /// </summary>
        public string TokenType => "Bearer";

        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }
    }
}
