// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.PowerShell;

    /// <summary>Gateway load balancer tunnel interface of a load balancer backend address pool.</summary>
    [System.ComponentModel.TypeConverter(typeof(GatewayLoadBalancerTunnelInterfaceTypeConverter))]
    public partial class GatewayLoadBalancerTunnelInterface
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.GatewayLoadBalancerTunnelInterface"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GatewayLoadBalancerTunnelInterface(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.GatewayLoadBalancerTunnelInterface"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GatewayLoadBalancerTunnelInterface(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GatewayLoadBalancerTunnelInterface" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="GatewayLoadBalancerTunnelInterface" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.GatewayLoadBalancerTunnelInterface"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GatewayLoadBalancerTunnelInterface(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Port"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Port = (int?) content.GetValueForProperty("Port",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Identifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Identifier = (int?) content.GetValueForProperty("Identifier",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Identifier, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Protocol"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Protocol = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.GatewayLoadBalancerTunnelProtocol?) content.GetValueForProperty("Protocol",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Protocol, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.GatewayLoadBalancerTunnelProtocol.CreateFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.GatewayLoadBalancerTunnelInterfaceType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.GatewayLoadBalancerTunnelInterfaceType.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.GatewayLoadBalancerTunnelInterface"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GatewayLoadBalancerTunnelInterface(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Port"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Port = (int?) content.GetValueForProperty("Port",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Identifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Identifier = (int?) content.GetValueForProperty("Identifier",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Identifier, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Protocol"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Protocol = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.GatewayLoadBalancerTunnelProtocol?) content.GetValueForProperty("Protocol",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Protocol, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.GatewayLoadBalancerTunnelProtocol.CreateFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.GatewayLoadBalancerTunnelInterfaceType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterfaceInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.GatewayLoadBalancerTunnelInterfaceType.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Gateway load balancer tunnel interface of a load balancer backend address pool.
    [System.ComponentModel.TypeConverter(typeof(GatewayLoadBalancerTunnelInterfaceTypeConverter))]
    public partial interface IGatewayLoadBalancerTunnelInterface

    {

    }
}