using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Role is a namespaced, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding.
    /// </summary>
    [KubeObject("Role", "rbac.authorization.k8s.io/v1beta1")]
    public partial class RoleV1Beta1 : KubeResourceV1
    {
        /// <summary>
        ///     Rules holds all the PolicyRules for this Role
        /// </summary>
        [YamlMember(Alias = "rules")]
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<PolicyRuleV1Beta1> Rules { get; set; } = new List<PolicyRuleV1Beta1>();
    }
}
