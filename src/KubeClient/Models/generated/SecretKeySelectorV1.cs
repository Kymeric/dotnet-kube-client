using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     SecretKeySelector selects a key of a Secret.
    /// </summary>
    public partial class SecretKeySelectorV1
    {
        /// <summary>
        ///     Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [JsonProperty("name")]
        [YamlMember(Alias = "name")]
        public virtual string Name { get; set; }

        /// <summary>
        ///     Specify whether the Secret or it's key must be defined
        /// </summary>
        [JsonProperty("optional")]
        [YamlMember(Alias = "optional")]
        public virtual bool Optional { get; set; }

        /// <summary>
        ///     The key of the secret to select from.  Must be a valid secret key.
        /// </summary>
        [JsonProperty("key")]
        [YamlMember(Alias = "key")]
        public virtual string Key { get; set; }
    }
}
