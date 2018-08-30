using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     SecurityContext holds security configuration that will be applied to a container. Some fields are present in both SecurityContext and PodSecurityContext.  When both are set, the values in SecurityContext take precedence.
    /// </summary>
    public partial class SecurityContextV1
    {
        /// <summary>
        ///     Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false.
        /// </summary>
        [JsonProperty("privileged")]
        [YamlMember(Alias = "privileged")]
        public virtual bool Privileged { get; set; }

        /// <summary>
        ///     Whether this container has a read-only root filesystem. Default is false.
        /// </summary>
        [JsonProperty("readOnlyRootFilesystem")]
        [YamlMember(Alias = "readOnlyRootFilesystem")]
        public virtual bool ReadOnlyRootFilesystem { get; set; }

        /// <summary>
        ///     The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        [JsonProperty("runAsUser")]
        [YamlMember(Alias = "runAsUser")]
        public virtual int RunAsUser { get; set; }

        /// <summary>
        ///     The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime.
        /// </summary>
        [JsonProperty("capabilities")]
        [YamlMember(Alias = "capabilities")]
        public virtual CapabilitiesV1 Capabilities { get; set; }

        /// <summary>
        ///     The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        [JsonProperty("seLinuxOptions")]
        [YamlMember(Alias = "seLinuxOptions")]
        public virtual SELinuxOptionsV1 SeLinuxOptions { get; set; }

        /// <summary>
        ///     Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        [JsonProperty("runAsNonRoot")]
        [YamlMember(Alias = "runAsNonRoot")]
        public virtual bool RunAsNonRoot { get; set; }
    }
}
