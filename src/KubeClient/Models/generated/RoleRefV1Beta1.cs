using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     RoleRef contains information that points to the role being used
    /// </summary>
    public partial class RoleRefV1Beta1
    {
        /// <summary>
        ///     Kind is the type of resource being referenced
        /// </summary>
        [JsonProperty("kind")]
        [YamlMember(Alias = "kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        ///     Name is the name of resource being referenced
        /// </summary>
        [JsonProperty("name")]
        [YamlMember(Alias = "name")]
        public virtual string Name { get; set; }

        /// <summary>
        ///     APIGroup is the group for the resource being referenced
        /// </summary>
        [JsonProperty("apiGroup")]
        [YamlMember(Alias = "apiGroup")]
        public virtual string ApiGroup { get; set; }
    }
}
