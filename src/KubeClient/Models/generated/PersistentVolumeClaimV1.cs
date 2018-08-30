using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     PersistentVolumeClaim is a user's request for and claim to a persistent volume
    /// </summary>
    [KubeObject("PersistentVolumeClaim", "v1")]
    public partial class PersistentVolumeClaimV1 : KubeResourceV1
    {
        /// <summary>
        ///     Spec defines the desired characteristics of a volume requested by a pod author. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        [JsonProperty("spec")]
        [YamlMember(Alias = "spec")]
        public virtual PersistentVolumeClaimSpecV1 Spec { get; set; }

        /// <summary>
        ///     Status represents the current information/status of a persistent volume claim. Read-only. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        [JsonProperty("status")]
        [YamlMember(Alias = "status")]
        public virtual PersistentVolumeClaimStatusV1 Status { get; set; }
    }
}
