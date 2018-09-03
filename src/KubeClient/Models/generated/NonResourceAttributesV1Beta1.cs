using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     NonResourceAttributes includes the authorization attributes available for non-resource requests to the Authorizer interface
    /// </summary>
    public partial class NonResourceAttributesV1Beta1
    {
        /// <summary>
        ///     Path is the URL path of the request
        /// </summary>
        [JsonProperty("path")]
        [YamlMember(Alias = "path")]
        public string Path { get; set; }

        /// <summary>
        ///     Verb is the standard HTTP verb
        /// </summary>
        [JsonProperty("verb")]
        [YamlMember(Alias = "verb")]
        public string Verb { get; set; }
    }
}
