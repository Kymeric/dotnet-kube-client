using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     current status of a horizontal pod autoscaler
    /// </summary>
    public partial class HorizontalPodAutoscalerStatusV1
    {
        /// <summary>
        ///     current average CPU utilization over all pods, represented as a percentage of requested CPU, e.g. 70 means that an average pod is using now 70% of its requested CPU.
        /// </summary>
        [JsonProperty("currentCPUUtilizationPercentage")]
        [YamlMember(Alias = "currentCPUUtilizationPercentage")]
        public virtual int CurrentCPUUtilizationPercentage { get; set; }

        /// <summary>
        ///     last time the HorizontalPodAutoscaler scaled the number of pods; used by the autoscaler to control how often the number of pods is changed.
        /// </summary>
        [JsonProperty("lastScaleTime")]
        [YamlMember(Alias = "lastScaleTime")]
        public virtual DateTime? LastScaleTime { get; set; }

        /// <summary>
        ///     most recent generation observed by this autoscaler.
        /// </summary>
        [JsonProperty("observedGeneration")]
        [YamlMember(Alias = "observedGeneration")]
        public virtual int ObservedGeneration { get; set; }

        /// <summary>
        ///     current number of replicas of pods managed by this autoscaler.
        /// </summary>
        [JsonProperty("currentReplicas")]
        [YamlMember(Alias = "currentReplicas")]
        public virtual int CurrentReplicas { get; set; }

        /// <summary>
        ///     desired number of replicas of pods managed by this autoscaler.
        /// </summary>
        [JsonProperty("desiredReplicas")]
        [YamlMember(Alias = "desiredReplicas")]
        public virtual int DesiredReplicas { get; set; }
    }
}
