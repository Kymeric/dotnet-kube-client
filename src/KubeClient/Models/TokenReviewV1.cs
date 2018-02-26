using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     TokenReview attempts to authenticate a token to a known user. Note: TokenReview requests may be cached by the webhook token authenticator plugin in the kube-apiserver.
    /// </summary>
    [KubeObject("TokenReview", "v1")]
    public class TokenReviewV1 : KubeResourceV1
    {
        /// <summary>
        ///     Spec holds information about the request being evaluated
        /// </summary>
        [JsonProperty("spec")]
        public TokenReviewSpecV1 Spec { get; set; }

        /// <summary>
        ///     Status is filled in by the server and indicates whether the request can be authenticated.
        /// </summary>
        [JsonProperty("status")]
        public TokenReviewStatusV1 Status { get; set; }
    }
}
