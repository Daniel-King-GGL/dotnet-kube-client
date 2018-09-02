using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     RoleBinding references a role, but does not contain it.  It can reference a Role in the same namespace or a ClusterRole in the global namespace. It adds who information via Subjects and namespace information by which namespace it exists in.  RoleBindings in a given namespace only have effect in that namespace.
    /// </summary>
    [KubeObject("RoleBinding", "v1beta1")]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/rolebindings", KubeAction.List)]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/watch/rolebindings", KubeAction.WatchList)]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/watch/namespaces/{namespace}/rolebindings", KubeAction.WatchList)]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/watch/namespaces/{namespace}/rolebindings/{name}", KubeAction.Watch)]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/namespaces/{namespace}/rolebindings", KubeAction.Create, KubeAction.DeleteCollection, KubeAction.List)]
    [KubeApi("apis/rbac.authorization.k8s.io/v1beta1/namespaces/{namespace}/rolebindings/{name}", KubeAction.Delete, KubeAction.Get, KubeAction.Patch, KubeAction.Update)]
    public partial class RoleBindingV1Beta1 : KubeResourceV1
    {
        /// <summary>
        ///     RoleRef can reference a Role in the current namespace or a ClusterRole in the global namespace. If the RoleRef cannot be resolved, the Authorizer must return an error.
        /// </summary>
        [JsonProperty("roleRef")]
        [YamlMember(Alias = "roleRef")]
        public RoleRefV1Beta1 RoleRef { get; set; }

        /// <summary>
        ///     Subjects holds references to the objects the role applies to.
        /// </summary>
        [YamlMember(Alias = "subjects")]
        [JsonProperty("subjects", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubjectV1Beta1> Subjects { get; set; } = new List<SubjectV1Beta1>();
    }
}
