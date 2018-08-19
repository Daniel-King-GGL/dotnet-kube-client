using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     An APIVersion represents a single concrete version of an object model.
    /// </summary>
    public partial class APIVersionV1Beta1
    {
        /// <summary>
        ///     Name of this version (e.g. 'v1').
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
