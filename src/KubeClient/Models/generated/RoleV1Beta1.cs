using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Role is a namespaced, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding.
    /// </summary>
    [KubeObject("Role", "v1beta1")]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/roles", KubeAction.List)]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/watch/roles", KubeAction.WatchList)]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/watch/namespaces/{namespace}/roles", KubeAction.WatchList)]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/watch/namespaces/{namespace}/roles/{name}", KubeAction.Watch)]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/namespaces/{namespace}/roles", KubeAction.Create, KubeAction.DeleteCollection, KubeAction.List)]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/namespaces/{namespace}/roles/{name}", KubeAction.Delete, KubeAction.Get, KubeAction.Patch, KubeAction.Update)]
    public partial class RoleV1Beta1 : KubeResourceV1
    {
        /// <summary>
        ///     Rules holds all the PolicyRules for this Role
        /// </summary>
        [YamlMember(Alias = "rules")]
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyRuleV1Beta1> Rules { get; set; } = new List<PolicyRuleV1Beta1>();
    }
}
