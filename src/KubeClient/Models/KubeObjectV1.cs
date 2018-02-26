using System;
using System.Collections.Concurrent;
using System.Reflection;
using Newtonsoft.Json;

namespace KubeClient.Models
{
    /// <summary>
    ///     The base class for Kubernetes models.
    /// </summary>
    public class KubeObjectV1
    {
        /// <summary>
        ///     Model type metadata.
        /// </summary>
        static readonly ConcurrentDictionary<Type, (string kind, string apiVersion)> ModelMetadata = new ConcurrentDictionary<Type, (string kind, string apiVersion)>();

        /// <summary>
        ///     Create a new <see cref="KubeObjectV1"/>, automatically initialising <see cref="Kind"/> and <see cref="ApiVersion"/> (if possible).
        /// </summary>
        protected KubeObjectV1()
        {
            (Kind, ApiVersion) = ModelMetadata.GetOrAdd(GetType(), modelType =>
            {
                var kubeObjectAttribute = modelType.GetTypeInfo().GetCustomAttribute<KubeObjectAttribute>();
                if (kubeObjectAttribute != null)
                    return (kubeObjectAttribute.Kind, kubeObjectAttribute.ApiVersion);

                return (null, null);
            });
        }

        /// <summary>
        ///     Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty("kind")]
        public string Kind { get; set; }

        /// <summary>
        ///     APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; }
    }

    /// <summary>
    ///     Extension methods for <see cref="KubeObjectV1"/>.
    /// </summary>
    public static class KubeObjectExtensions
    {
        /// <summary>
        ///     Remove type metadata (Kind and ApiVersion) from the <see cref="KubeObjectV1"/>.
        /// </summary>
        /// <param name="kubeObject">
        ///     The <see cref="KubeObjectV1"/>.
        /// </param>
        /// <returns>
        ///     The <see cref="KubeObjectV1"/> (enables inline use).
        /// </returns>
        public static TObject NoTypeMeta<TObject>(this TObject kubeObject)
            where TObject : KubeObjectV1
        {
            if (kubeObject == null)
                return null;

            kubeObject.Kind = null;
            kubeObject.ApiVersion = null;

            return kubeObject;
        }
    }
}
