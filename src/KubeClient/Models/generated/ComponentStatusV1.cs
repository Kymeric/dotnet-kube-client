using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ComponentStatus (and ComponentStatusList) holds the cluster validation info.
    /// </summary>
    [KubeObject("ComponentStatus", "v1")]
    public partial class ComponentStatusV1 : KubeResourceV1
    {
        /// <summary>
        ///     List of component conditions observed
        /// </summary>
        [MergeStrategy(Key = "type")]
        [YamlMember(Alias = "conditions")]
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<ComponentConditionV1> Conditions { get; set; } = new List<ComponentConditionV1>();
    }
}
