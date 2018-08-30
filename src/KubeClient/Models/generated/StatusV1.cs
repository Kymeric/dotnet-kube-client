using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Status is a return value for calls that don't return other objects.
    /// </summary>
    [KubeObject("Status", "v1")]
    public partial class StatusV1 : KubeResourceListV1
    {
        /// <summary>
        ///     Suggested HTTP return code for this status, 0 if not set.
        /// </summary>
        [JsonProperty("code")]
        [YamlMember(Alias = "code")]
        public virtual int Code { get; set; }

        /// <summary>
        ///     A human-readable description of the status of this operation.
        /// </summary>
        [JsonProperty("message")]
        [YamlMember(Alias = "message")]
        public virtual string Message { get; set; }

        /// <summary>
        ///     A machine-readable description of why this operation is in the "Failure" status. If this value is empty there is no information available. A Reason clarifies an HTTP status code but does not override it.
        /// </summary>
        [JsonProperty("reason")]
        [YamlMember(Alias = "reason")]
        public virtual string Reason { get; set; }

        /// <summary>
        ///     Extended data associated with the reason.  Each reason may define its own extended details. This field is optional and the data returned is not guaranteed to conform to any schema except that defined by the reason type.
        /// </summary>
        [JsonProperty("details")]
        [YamlMember(Alias = "details")]
        public virtual StatusDetailsV1 Details { get; set; }

        /// <summary>
        ///     Status of the operation. One of: "Success" or "Failure". More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty("status")]
        [YamlMember(Alias = "status")]
        public virtual string Status { get; set; }
    }
}
