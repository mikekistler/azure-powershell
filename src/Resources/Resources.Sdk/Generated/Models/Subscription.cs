// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Resources.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Subscription information.
    /// </summary>
    public partial class Subscription
    {
        /// <summary>
        /// Initializes a new instance of the Subscription class.
        /// </summary>
        public Subscription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Subscription class.
        /// </summary>
        /// <param name="id">The fully qualified ID for the subscription. For
        /// example,
        /// /subscriptions/00000000-0000-0000-0000-000000000000.</param>
        /// <param name="subscriptionId">The subscription ID.</param>
        /// <param name="displayName">The subscription display name.</param>
        /// <param name="tenantId">The subscription tenant ID.</param>
        /// <param name="state">The subscription state. Possible values are
        /// Enabled, Warned, PastDue, Disabled, and Deleted. Possible values
        /// include: 'Enabled', 'Warned', 'PastDue', 'Disabled',
        /// 'Deleted'</param>
        /// <param name="subscriptionPolicies">The subscription
        /// policies.</param>
        /// <param name="authorizationSource">The authorization source of the
        /// request. Valid values are one or more combinations of Legacy,
        /// RoleBased, Bypassed, Direct and Management. For example, 'Legacy,
        /// RoleBased'.</param>
        /// <param name="managedByTenants">An array containing the tenants
        /// managing the subscription.</param>
        /// <param name="tags">The tags attached to the subscription.</param>
        public Subscription(string id = default(string), string subscriptionId = default(string), string displayName = default(string), string tenantId = default(string), SubscriptionState? state = default(SubscriptionState?), SubscriptionPolicies subscriptionPolicies = default(SubscriptionPolicies), string authorizationSource = default(string), IList<ManagedByTenant> managedByTenants = default(IList<ManagedByTenant>), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Id = id;
            SubscriptionId = subscriptionId;
            DisplayName = displayName;
            TenantId = tenantId;
            State = state;
            SubscriptionPolicies = subscriptionPolicies;
            AuthorizationSource = authorizationSource;
            ManagedByTenants = managedByTenants;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the fully qualified ID for the subscription. For example,
        /// /subscriptions/00000000-0000-0000-0000-000000000000.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the subscription ID.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; private set; }

        /// <summary>
        /// Gets the subscription display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the subscription tenant ID.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets the subscription state. Possible values are Enabled, Warned,
        /// PastDue, Disabled, and Deleted. Possible values include: 'Enabled',
        /// 'Warned', 'PastDue', 'Disabled', 'Deleted'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public SubscriptionState? State { get; private set; }

        /// <summary>
        /// Gets or sets the subscription policies.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionPolicies")]
        public SubscriptionPolicies SubscriptionPolicies { get; set; }

        /// <summary>
        /// Gets or sets the authorization source of the request. Valid values
        /// are one or more combinations of Legacy, RoleBased, Bypassed, Direct
        /// and Management. For example, 'Legacy, RoleBased'.
        /// </summary>
        [JsonProperty(PropertyName = "authorizationSource")]
        public string AuthorizationSource { get; set; }

        /// <summary>
        /// Gets or sets an array containing the tenants managing the
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "managedByTenants")]
        public IList<ManagedByTenant> ManagedByTenants { get; set; }

        /// <summary>
        /// Gets or sets the tags attached to the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
