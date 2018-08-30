using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     CronJobSpec describes how the job execution will look like and when it will actually run.
    /// </summary>
    public partial class CronJobSpecV2Alpha1
    {
        /// <summary>
        ///     This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.  Defaults to false.
        /// </summary>
        [JsonProperty("suspend")]
        [YamlMember(Alias = "suspend")]
        public virtual bool Suspend { get; set; }

        /// <summary>
        ///     Specifies the job that will be created when executing a CronJob.
        /// </summary>
        [JsonProperty("jobTemplate")]
        [YamlMember(Alias = "jobTemplate")]
        public virtual JobTemplateSpecV2Alpha1 JobTemplate { get; set; }

        /// <summary>
        ///     The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.
        /// </summary>
        [JsonProperty("schedule")]
        [YamlMember(Alias = "schedule")]
        public virtual string Schedule { get; set; }

        /// <summary>
        ///     Optional deadline in seconds for starting the job if it misses scheduled time for any reason.  Missed jobs executions will be counted as failed ones.
        /// </summary>
        [JsonProperty("startingDeadlineSeconds")]
        [YamlMember(Alias = "startingDeadlineSeconds")]
        public virtual int? StartingDeadlineSeconds { get; set; }

        /// <summary>
        ///     The number of failed finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.
        /// </summary>
        [JsonProperty("failedJobsHistoryLimit")]
        [YamlMember(Alias = "failedJobsHistoryLimit")]
        public virtual int FailedJobsHistoryLimit { get; set; }

        /// <summary>
        ///     The number of successful finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.
        /// </summary>
        [JsonProperty("successfulJobsHistoryLimit")]
        [YamlMember(Alias = "successfulJobsHistoryLimit")]
        public virtual int SuccessfulJobsHistoryLimit { get; set; }

        /// <summary>
        ///     Specifies how to treat concurrent executions of a Job. Defaults to Allow.
        /// </summary>
        [JsonProperty("concurrencyPolicy")]
        [YamlMember(Alias = "concurrencyPolicy")]
        public virtual string ConcurrencyPolicy { get; set; }
    }
}
