using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ReplicaSetStatus represents the current status of a ReplicaSet.
    /// </summary>
    public partial class ReplicaSetStatusV1Beta1
    {
        /// <summary>
        ///     ObservedGeneration reflects the generation of the most recently observed ReplicaSet.
        /// </summary>
        [JsonProperty("observedGeneration")]
        [YamlMember(Alias = "observedGeneration")]
        public virtual int ObservedGeneration { get; set; }

        /// <summary>
        ///     The number of available replicas (ready for at least minReadySeconds) for this replica set.
        /// </summary>
        [JsonProperty("availableReplicas")]
        [YamlMember(Alias = "availableReplicas")]
        public virtual int AvailableReplicas { get; set; }

        /// <summary>
        ///     Represents the latest available observations of a replica set's current state.
        /// </summary>
        [MergeStrategy(Key = "type")]
        [YamlMember(Alias = "conditions")]
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<ReplicaSetConditionV1Beta1> Conditions { get; set; } = new List<ReplicaSetConditionV1Beta1>();

        /// <summary>
        ///     The number of pods that have labels matching the labels of the pod template of the replicaset.
        /// </summary>
        [JsonProperty("fullyLabeledReplicas")]
        [YamlMember(Alias = "fullyLabeledReplicas")]
        public virtual int FullyLabeledReplicas { get; set; }

        /// <summary>
        ///     The number of ready replicas for this replica set.
        /// </summary>
        [JsonProperty("readyReplicas")]
        [YamlMember(Alias = "readyReplicas")]
        public virtual int ReadyReplicas { get; set; }

        /// <summary>
        ///     Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller
        /// </summary>
        [JsonProperty("replicas")]
        [YamlMember(Alias = "replicas")]
        public virtual int Replicas { get; set; }
    }
}
