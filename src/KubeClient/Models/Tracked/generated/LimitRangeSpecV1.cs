using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models.Tracked
{
    /// <summary>
    ///     LimitRangeSpec defines a min/max usage limit for resources that match on kind.
    /// </summary>
    public partial class LimitRangeSpecV1 : Models.LimitRangeSpecV1
    {
        /// <summary>
        ///     Limits is the list of LimitRangeItem objects that are enforced.
        /// </summary>
        [YamlMember(Alias = "limits")]
        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public override List<Models.LimitRangeItemV1> Limits { get; set; } = new List<Models.LimitRangeItemV1>();
    }
}
