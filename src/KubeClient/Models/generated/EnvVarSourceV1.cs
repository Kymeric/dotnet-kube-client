using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     EnvVarSource represents a source for the value of an EnvVar.
    /// </summary>
    public partial class EnvVarSourceV1
    {
        /// <summary>
        ///     Selects a key of a ConfigMap.
        /// </summary>
        [JsonProperty("configMapKeyRef")]
        [YamlMember(Alias = "configMapKeyRef")]
        public virtual ConfigMapKeySelectorV1 ConfigMapKeyRef { get; set; }

        /// <summary>
        ///     Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.
        /// </summary>
        [JsonProperty("fieldRef")]
        [YamlMember(Alias = "fieldRef")]
        public virtual ObjectFieldSelectorV1 FieldRef { get; set; }

        /// <summary>
        ///     Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.
        /// </summary>
        [JsonProperty("resourceFieldRef")]
        [YamlMember(Alias = "resourceFieldRef")]
        public virtual ResourceFieldSelectorV1 ResourceFieldRef { get; set; }

        /// <summary>
        ///     Selects a key of a secret in the pod's namespace
        /// </summary>
        [JsonProperty("secretKeyRef")]
        [YamlMember(Alias = "secretKeyRef")]
        public virtual SecretKeySelectorV1 SecretKeyRef { get; set; }
    }
}
