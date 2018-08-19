using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     ClusterRole is a cluster level, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding or ClusterRoleBinding.
    /// </summary>
    [KubeObject("ClusterRole", "rbac.authorization.k8s.io/v1beta1")]
    public partial class ClusterRoleV1Beta1 : KubeResourceV1
    {
        /// <summary>
        ///     Rules holds all the PolicyRules for this ClusterRole
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyRuleV1Beta1> Rules { get; set; } = new List<PolicyRuleV1Beta1>();
    }
}
