using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     StatusDetails is a set of additional properties that MAY be set by the server to provide additional information about a response. The Reason field of a Status object defines what attributes will be set. Clients must ignore fields that do not match the defined type of each attribute, and should assume that any attribute may be empty, invalid, or under defined.
    /// </summary>
    public partial class StatusDetailsV1
    {
        /// <summary>
        ///     The kind attribute of the resource associated with the status StatusReason. On some operations may differ from the requested resource Kind. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty("kind")]
        [YamlMember(Alias = "kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        ///     UID of the resource. (when there is a single resource which can be described). More info: http://kubernetes.io/docs/user-guide/identifiers#uids
        /// </summary>
        [JsonProperty("uid")]
        [YamlMember(Alias = "uid")]
        public virtual string Uid { get; set; }

        /// <summary>
        ///     The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).
        /// </summary>
        [JsonProperty("name")]
        [YamlMember(Alias = "name")]
        public virtual string Name { get; set; }

        /// <summary>
        ///     The group attribute of the resource associated with the status StatusReason.
        /// </summary>
        [JsonProperty("group")]
        [YamlMember(Alias = "group")]
        public virtual string Group { get; set; }

        /// <summary>
        ///     The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may provide detailed causes.
        /// </summary>
        [YamlMember(Alias = "causes")]
        [JsonProperty("causes", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<StatusCauseV1> Causes { get; set; } = new List<StatusCauseV1>();

        /// <summary>
        ///     If specified, the time in seconds before the operation should be retried.
        /// </summary>
        [JsonProperty("retryAfterSeconds")]
        [YamlMember(Alias = "retryAfterSeconds")]
        public virtual int RetryAfterSeconds { get; set; }
    }
}
