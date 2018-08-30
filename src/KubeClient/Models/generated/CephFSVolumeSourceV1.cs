using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs volumes do not support ownership management or SELinux relabeling.
    /// </summary>
    public partial class CephFSVolumeSourceV1
    {
        /// <summary>
        ///     Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [JsonProperty("secretFile")]
        [YamlMember(Alias = "secretFile")]
        public virtual string SecretFile { get; set; }

        /// <summary>
        ///     Optional: SecretRef is reference to the authentication secret for User, default is empty. More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [JsonProperty("secretRef")]
        [YamlMember(Alias = "secretRef")]
        public virtual LocalObjectReferenceV1 SecretRef { get; set; }

        /// <summary>
        ///     Optional: Used as the mounted root, rather than the full Ceph tree, default is /
        /// </summary>
        [JsonProperty("path")]
        [YamlMember(Alias = "path")]
        public virtual string Path { get; set; }

        /// <summary>
        ///     Optional: User is the rados user name, default is admin More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [JsonProperty("user")]
        [YamlMember(Alias = "user")]
        public virtual string User { get; set; }

        /// <summary>
        ///     Required: Monitors is a collection of Ceph monitors More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [YamlMember(Alias = "monitors")]
        [JsonProperty("monitors", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<string> Monitors { get; set; } = new List<string>();

        /// <summary>
        ///     Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [JsonProperty("readOnly")]
        [YamlMember(Alias = "readOnly")]
        public virtual bool ReadOnly { get; set; }
    }
}
