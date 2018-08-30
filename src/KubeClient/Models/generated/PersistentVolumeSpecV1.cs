using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     PersistentVolumeSpec is the specification of a persistent volume.
    /// </summary>
    public partial class PersistentVolumeSpecV1
    {
        /// <summary>
        ///     ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.
        /// </summary>
        [JsonProperty("scaleIO")]
        [YamlMember(Alias = "scaleIO")]
        public virtual ScaleIOVolumeSourceV1 ScaleIO { get; set; }

        /// <summary>
        ///     FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
        /// </summary>
        [JsonProperty("fc")]
        [YamlMember(Alias = "fc")]
        public virtual FCVolumeSourceV1 Fc { get; set; }

        /// <summary>
        ///     RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md
        /// </summary>
        [JsonProperty("rbd")]
        [YamlMember(Alias = "rbd")]
        public virtual RBDVolumeSourceV1 Rbd { get; set; }

        /// <summary>
        ///     AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        [JsonProperty("awsElasticBlockStore")]
        [YamlMember(Alias = "awsElasticBlockStore")]
        public virtual AWSElasticBlockStoreVolumeSourceV1 AwsElasticBlockStore { get; set; }

        /// <summary>
        ///     AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
        /// </summary>
        [JsonProperty("azureFile")]
        [YamlMember(Alias = "azureFile")]
        public virtual AzureFileVolumeSourceV1 AzureFile { get; set; }

        /// <summary>
        ///     FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin. This is an alpha feature and may change in future.
        /// </summary>
        [JsonProperty("flexVolume")]
        [YamlMember(Alias = "flexVolume")]
        public virtual FlexVolumeSourceV1 FlexVolume { get; set; }

        /// <summary>
        ///     PortworxVolume represents a portworx volume attached and mounted on kubelets host machine
        /// </summary>
        [JsonProperty("portworxVolume")]
        [YamlMember(Alias = "portworxVolume")]
        public virtual PortworxVolumeSourceV1 PortworxVolume { get; set; }

        /// <summary>
        ///     Quobyte represents a Quobyte mount on the host that shares a pod's lifetime
        /// </summary>
        [JsonProperty("quobyte")]
        [YamlMember(Alias = "quobyte")]
        public virtual QuobyteVolumeSourceV1 Quobyte { get; set; }

        /// <summary>
        ///     Name of StorageClass to which this persistent volume belongs. Empty value means that this volume does not belong to any StorageClass.
        /// </summary>
        [JsonProperty("storageClassName")]
        [YamlMember(Alias = "storageClassName")]
        public virtual string StorageClassName { get; set; }

        /// <summary>
        ///     VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine
        /// </summary>
        [JsonProperty("vsphereVolume")]
        [YamlMember(Alias = "vsphereVolume")]
        public virtual VsphereVirtualDiskVolumeSourceV1 VsphereVolume { get; set; }

        /// <summary>
        ///     ClaimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim. Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding
        /// </summary>
        [JsonProperty("claimRef")]
        [YamlMember(Alias = "claimRef")]
        public virtual ObjectReferenceV1 ClaimRef { get; set; }

        /// <summary>
        ///     HostPath represents a directory on the host. Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [JsonProperty("hostPath")]
        [YamlMember(Alias = "hostPath")]
        public virtual HostPathVolumeSourceV1 HostPath { get; set; }

        /// <summary>
        ///     ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin.
        /// </summary>
        [JsonProperty("iscsi")]
        [YamlMember(Alias = "iscsi")]
        public virtual ISCSIVolumeSourceV1 Iscsi { get; set; }

        /// <summary>
        ///     AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
        /// </summary>
        [JsonProperty("azureDisk")]
        [YamlMember(Alias = "azureDisk")]
        public virtual AzureDiskVolumeSourceV1 AzureDisk { get; set; }

        /// <summary>
        ///     GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty("gcePersistentDisk")]
        [YamlMember(Alias = "gcePersistentDisk")]
        public virtual GCEPersistentDiskVolumeSourceV1 GcePersistentDisk { get; set; }

        /// <summary>
        ///     PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine
        /// </summary>
        [JsonProperty("photonPersistentDisk")]
        [YamlMember(Alias = "photonPersistentDisk")]
        public virtual PhotonPersistentDiskVolumeSourceV1 PhotonPersistentDisk { get; set; }

        /// <summary>
        ///     Local represents directly-attached storage with node affinity
        /// </summary>
        [JsonProperty("local")]
        [YamlMember(Alias = "local")]
        public virtual LocalVolumeSourceV1 Local { get; set; }

        /// <summary>
        ///     Cinder represents a cinder volume attached and mounted on kubelets host machine More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
        /// </summary>
        [JsonProperty("cinder")]
        [YamlMember(Alias = "cinder")]
        public virtual CinderVolumeSourceV1 Cinder { get; set; }

        /// <summary>
        ///     Flocker represents a Flocker volume attached to a kubelet's host machine and exposed to the pod for its usage. This depends on the Flocker control service being running
        /// </summary>
        [JsonProperty("flocker")]
        [YamlMember(Alias = "flocker")]
        public virtual FlockerVolumeSourceV1 Flocker { get; set; }

        /// <summary>
        ///     AccessModes contains all ways the volume can be mounted. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes
        /// </summary>
        [YamlMember(Alias = "accessModes")]
        [JsonProperty("accessModes", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<string> AccessModes { get; set; } = new List<string>();

        /// <summary>
        ///     CephFS represents a Ceph FS mount on the host that shares a pod's lifetime
        /// </summary>
        [JsonProperty("cephfs")]
        [YamlMember(Alias = "cephfs")]
        public virtual CephFSVolumeSourceV1 Cephfs { get; set; }

        /// <summary>
        ///     Glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod. Provisioned by an admin. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md
        /// </summary>
        [JsonProperty("glusterfs")]
        [YamlMember(Alias = "glusterfs")]
        public virtual GlusterfsVolumeSourceV1 Glusterfs { get; set; }

        /// <summary>
        ///     NFS represents an NFS mount on the host. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        [JsonProperty("nfs")]
        [YamlMember(Alias = "nfs")]
        public virtual NFSVolumeSourceV1 Nfs { get; set; }

        /// <summary>
        ///     StorageOS represents a StorageOS volume that is attached to the kubelet's host machine and mounted into the pod More info: https://releases.k8s.io/HEAD/examples/volumes/storageos/README.md
        /// </summary>
        [JsonProperty("storageos")]
        [YamlMember(Alias = "storageos")]
        public virtual StorageOSPersistentVolumeSourceV1 Storageos { get; set; }

        /// <summary>
        ///     A description of the persistent volume's resources and capacity. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity
        /// </summary>
        [YamlMember(Alias = "capacity")]
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Dictionary<string, string> Capacity { get; set; } = new Dictionary<string, string>();

        /// <summary>
        ///     What happens to a persistent volume when released from its claim. Valid options are Retain (default) and Recycle. Recycling must be supported by the volume plugin underlying this persistent volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming
        /// </summary>
        [JsonProperty("persistentVolumeReclaimPolicy")]
        [YamlMember(Alias = "persistentVolumeReclaimPolicy")]
        public virtual string PersistentVolumeReclaimPolicy { get; set; }
    }
}
