// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// KEDA (Kubernetes Event-driven Autoscaling) settings for the workload
    /// auto-scaler profile.
    /// </summary>
    public partial class ManagedClusterWorkloadAutoScalerProfileKeda
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterWorkloadAutoScalerProfileKeda class.
        /// </summary>
        public ManagedClusterWorkloadAutoScalerProfileKeda()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterWorkloadAutoScalerProfileKeda class.
        /// </summary>
        /// <param name="enabled">Whether to enable KEDA.</param>
        public ManagedClusterWorkloadAutoScalerProfileKeda(bool enabled)
        {
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether to enable KEDA.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
