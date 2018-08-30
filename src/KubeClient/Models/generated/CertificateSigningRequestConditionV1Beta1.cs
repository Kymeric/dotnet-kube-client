using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     No description provided.
    /// </summary>
    public partial class CertificateSigningRequestConditionV1Beta1
    {
        /// <summary>
        ///     timestamp for the last update to this condition
        /// </summary>
        [JsonProperty("lastUpdateTime")]
        [YamlMember(Alias = "lastUpdateTime")]
        public virtual DateTime? LastUpdateTime { get; set; }

        /// <summary>
        ///     human readable message with details about the request state
        /// </summary>
        [JsonProperty("message")]
        [YamlMember(Alias = "message")]
        public virtual string Message { get; set; }

        /// <summary>
        ///     request approval state, currently Approved or Denied.
        /// </summary>
        [JsonProperty("type")]
        [YamlMember(Alias = "type")]
        public virtual string Type { get; set; }

        /// <summary>
        ///     brief reason for the request state
        /// </summary>
        [JsonProperty("reason")]
        [YamlMember(Alias = "reason")]
        public virtual string Reason { get; set; }
    }
}
