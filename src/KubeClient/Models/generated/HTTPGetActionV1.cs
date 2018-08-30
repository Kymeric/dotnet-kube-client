using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     HTTPGetAction describes an action based on HTTP Get requests.
    /// </summary>
    public partial class HTTPGetActionV1
    {
        /// <summary>
        ///     Scheme to use for connecting to the host. Defaults to HTTP.
        /// </summary>
        [JsonProperty("scheme")]
        [YamlMember(Alias = "scheme")]
        public virtual string Scheme { get; set; }

        /// <summary>
        ///     Path to access on the HTTP server.
        /// </summary>
        [JsonProperty("path")]
        [YamlMember(Alias = "path")]
        public virtual string Path { get; set; }

        /// <summary>
        ///     Custom headers to set in the request. HTTP allows repeated headers.
        /// </summary>
        [YamlMember(Alias = "httpHeaders")]
        [JsonProperty("httpHeaders", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<HTTPHeaderV1> HttpHeaders { get; set; } = new List<HTTPHeaderV1>();

        /// <summary>
        ///     Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.
        /// </summary>
        [JsonProperty("host")]
        [YamlMember(Alias = "host")]
        public virtual string Host { get; set; }

        /// <summary>
        ///     Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
        /// </summary>
        [JsonProperty("port")]
        [YamlMember(Alias = "port")]
        public virtual string Port { get; set; }
    }
}
