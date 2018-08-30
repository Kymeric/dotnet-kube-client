using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ServiceReference holds a reference to Service.legacy.k8s.io
    /// </summary>
    public partial class ServiceReferenceV1Beta1
    {
        /// <summary>
        ///     Name is the name of the service
        /// </summary>
        [JsonProperty("name")]
        [YamlMember(Alias = "name")]
        public virtual string Name { get; set; }

        /// <summary>
        ///     Namespace is the namespace of the service
        /// </summary>
        [JsonProperty("namespace")]
        [YamlMember(Alias = "namespace")]
        public virtual string Namespace { get; set; }
    }
}
