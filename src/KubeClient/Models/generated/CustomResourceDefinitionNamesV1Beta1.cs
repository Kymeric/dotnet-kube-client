using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     CustomResourceDefinitionNames indicates the names to serve this CustomResourceDefinition
    /// </summary>
    public partial class CustomResourceDefinitionNamesV1Beta1
    {
        /// <summary>
        ///     Kind is the serialized kind of the resource.  It is normally CamelCase and singular.
        /// </summary>
        [JsonProperty("kind")]
        [YamlMember(Alias = "kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        ///     ListKind is the serialized kind of the list for this resource.  Defaults to &lt;kind&gt;List.
        /// </summary>
        [JsonProperty("listKind")]
        [YamlMember(Alias = "listKind")]
        public virtual string ListKind { get; set; }

        /// <summary>
        ///     Plural is the plural name of the resource to serve.  It must match the name of the CustomResourceDefinition-registration too: plural.group and it must be all lowercase.
        /// </summary>
        [JsonProperty("plural")]
        [YamlMember(Alias = "plural")]
        public virtual string Plural { get; set; }

        /// <summary>
        ///     Singular is the singular name of the resource.  It must be all lowercase  Defaults to lowercased &lt;kind&gt;
        /// </summary>
        [JsonProperty("singular")]
        [YamlMember(Alias = "singular")]
        public virtual string Singular { get; set; }

        /// <summary>
        ///     ShortNames are short names for the resource.  It must be all lowercase.
        /// </summary>
        [YamlMember(Alias = "shortNames")]
        [JsonProperty("shortNames", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<string> ShortNames { get; set; } = new List<string>();
    }
}
