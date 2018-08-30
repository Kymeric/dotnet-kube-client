using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     No description provided.
    /// </summary>
    public partial class CertificateSigningRequestStatusV1Beta1
    {
        /// <summary>
        ///     If request was approved, the controller will place the issued certificate here.
        /// </summary>
        [JsonProperty("certificate")]
        [YamlMember(Alias = "certificate")]
        public virtual string Certificate { get; set; }

        /// <summary>
        ///     Conditions applied to the request, such as approval or denial.
        /// </summary>
        [YamlMember(Alias = "conditions")]
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<CertificateSigningRequestConditionV1Beta1> Conditions { get; set; } = new List<CertificateSigningRequestConditionV1Beta1>();
    }
}
