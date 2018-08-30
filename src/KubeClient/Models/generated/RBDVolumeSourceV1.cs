using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Represents a Rados Block Device mount that lasts the lifetime of a pod. RBD volumes support ownership management and SELinux relabeling.
    /// </summary>
    public partial class RBDVolumeSourceV1
    {
        /// <summary>
        ///     Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd
        /// </summary>
        [JsonProperty("fsType")]
        [YamlMember(Alias = "fsType")]
        public virtual string FsType { get; set; }

        /// <summary>
        ///     The rados image name. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty("image")]
        [YamlMember(Alias = "image")]
        public virtual string Image { get; set; }

        /// <summary>
        ///     SecretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is nil. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty("secretRef")]
        [YamlMember(Alias = "secretRef")]
        public virtual LocalObjectReferenceV1 SecretRef { get; set; }

        /// <summary>
        ///     Keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty("keyring")]
        [YamlMember(Alias = "keyring")]
        public virtual string Keyring { get; set; }

        /// <summary>
        ///     The rados pool name. Default is rbd. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty("pool")]
        [YamlMember(Alias = "pool")]
        public virtual string Pool { get; set; }

        /// <summary>
        ///     The rados user name. Default is admin. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty("user")]
        [YamlMember(Alias = "user")]
        public virtual string User { get; set; }

        /// <summary>
        ///     A collection of Ceph monitors. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [YamlMember(Alias = "monitors")]
        [JsonProperty("monitors", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<string> Monitors { get; set; } = new List<string>();

        /// <summary>
        ///     ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty("readOnly")]
        [YamlMember(Alias = "readOnly")]
        public virtual bool ReadOnly { get; set; }
    }
}
