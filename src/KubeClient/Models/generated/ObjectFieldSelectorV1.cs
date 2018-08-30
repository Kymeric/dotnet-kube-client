using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ObjectFieldSelector selects an APIVersioned field of an object.
    /// </summary>
    public partial class ObjectFieldSelectorV1
    {
        /// <summary>
        ///     Path of the field to select in the specified API version.
        /// </summary>
        [JsonProperty("fieldPath")]
        [YamlMember(Alias = "fieldPath")]
        public virtual string FieldPath { get; set; }

        /// <summary>
        ///     Version of the schema the FieldPath is written in terms of, defaults to "v1".
        /// </summary>
        [JsonProperty("apiVersion")]
        [YamlMember(Alias = "apiVersion")]
        public virtual string ApiVersion { get; set; }
    }
}
