using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     NodeSystemInfo is a set of ids/uuids to uniquely identify the node.
    /// </summary>
    public partial class NodeSystemInfoV1
    {
        /// <summary>
        ///     Boot ID reported by the node.
        /// </summary>
        [JsonProperty("bootID")]
        [YamlMember(Alias = "bootID")]
        public virtual string BootID { get; set; }

        /// <summary>
        ///     MachineID reported by the node. For unique machine identification in the cluster this field is preferred. Learn more from man(5) machine-id: http://man7.org/linux/man-pages/man5/machine-id.5.html
        /// </summary>
        [JsonProperty("machineID")]
        [YamlMember(Alias = "machineID")]
        public virtual string MachineID { get; set; }

        /// <summary>
        ///     SystemUUID reported by the node. For unique machine identification MachineID is preferred. This field is specific to Red Hat hosts https://access.redhat.com/documentation/en-US/Red_Hat_Subscription_Management/1/html/RHSM/getting-system-uuid.html
        /// </summary>
        [JsonProperty("systemUUID")]
        [YamlMember(Alias = "systemUUID")]
        public virtual string SystemUUID { get; set; }

        /// <summary>
        ///     The Architecture reported by the node
        /// </summary>
        [JsonProperty("architecture")]
        [YamlMember(Alias = "architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>
        ///     OS Image reported by the node from /etc/os-release (e.g. Debian GNU/Linux 7 (wheezy)).
        /// </summary>
        [JsonProperty("osImage")]
        [YamlMember(Alias = "osImage")]
        public virtual string OsImage { get; set; }

        /// <summary>
        ///     The Operating System reported by the node
        /// </summary>
        [JsonProperty("operatingSystem")]
        [YamlMember(Alias = "operatingSystem")]
        public virtual string OperatingSystem { get; set; }

        /// <summary>
        ///     ContainerRuntime Version reported by the node through runtime remote API (e.g. docker://1.5.0).
        /// </summary>
        [JsonProperty("containerRuntimeVersion")]
        [YamlMember(Alias = "containerRuntimeVersion")]
        public virtual string ContainerRuntimeVersion { get; set; }

        /// <summary>
        ///     Kernel Version reported by the node from 'uname -r' (e.g. 3.16.0-0.bpo.4-amd64).
        /// </summary>
        [JsonProperty("kernelVersion")]
        [YamlMember(Alias = "kernelVersion")]
        public virtual string KernelVersion { get; set; }

        /// <summary>
        ///     KubeProxy Version reported by the node.
        /// </summary>
        [JsonProperty("kubeProxyVersion")]
        [YamlMember(Alias = "kubeProxyVersion")]
        public virtual string KubeProxyVersion { get; set; }

        /// <summary>
        ///     Kubelet Version reported by the node.
        /// </summary>
        [JsonProperty("kubeletVersion")]
        [YamlMember(Alias = "kubeletVersion")]
        public virtual string KubeletVersion { get; set; }
    }
}
