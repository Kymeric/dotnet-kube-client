using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Information about the condition of a component.
    /// </summary>
    public partial class ComponentConditionV1
    {
        /// <summary>
        ///     Message about the condition for a component. For example, information about a health check.
        /// </summary>
        [JsonProperty("message")]
        [YamlMember(Alias = "message")]
        public virtual string Message { get; set; }

        /// <summary>
        ///     Type of condition for a component. Valid value: "Healthy"
        /// </summary>
        [JsonProperty("type")]
        [YamlMember(Alias = "type")]
        public virtual string Type { get; set; }

        /// <summary>
        ///     Condition error code for a component. For example, a health check error code.
        /// </summary>
        [JsonProperty("error")]
        [YamlMember(Alias = "error")]
        public virtual string Error { get; set; }

        /// <summary>
        ///     Status of the condition for a component. Valid values for "Healthy": "True", "False", or "Unknown".
        /// </summary>
        [JsonProperty("status")]
        [YamlMember(Alias = "status")]
        public virtual string Status { get; set; }
    }
}
