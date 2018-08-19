using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     IngressStatus describe the current state of the Ingress.
    /// </summary>
    public partial class IngressStatusV1Beta1
    {
        /// <summary>
        ///     LoadBalancer contains the current status of the load-balancer.
        /// </summary>
        [JsonProperty("loadBalancer")]
        public LoadBalancerStatusV1 LoadBalancer { get; set; }
    }
}
