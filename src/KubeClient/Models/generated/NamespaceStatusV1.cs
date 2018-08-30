using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     NamespaceStatus is information about the current status of a Namespace.
    /// </summary>
    public partial class NamespaceStatusV1
    {
        /// <summary>
        ///     Phase is the current lifecycle phase of the namespace. More info: https://git.k8s.io/community/contributors/design-proposals/namespaces.md#phases
        /// </summary>
        [JsonProperty("phase")]
        [YamlMember(Alias = "phase")]
        public virtual string Phase { get; set; }
    }
}
