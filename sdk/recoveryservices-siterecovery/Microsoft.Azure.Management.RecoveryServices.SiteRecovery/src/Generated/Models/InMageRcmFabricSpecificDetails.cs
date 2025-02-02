// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// InMageRcm fabric specific details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageRcm")]
    public partial class InMageRcmFabricSpecificDetails : FabricSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMageRcmFabricSpecificDetails
        /// class.
        /// </summary>
        public InMageRcmFabricSpecificDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageRcmFabricSpecificDetails
        /// class.
        /// </summary>
        /// <param name="vmwareSiteId">The ARM Id of the VMware site.</param>
        /// <param name="physicalSiteId">The ARM Id of the physical
        /// site.</param>
        /// <param name="serviceEndpoint">The service endpoint.</param>
        /// <param name="serviceResourceId">The service resource Id.</param>
        /// <param name="serviceContainerId">The service container Id.</param>
        /// <param name="dataPlaneUri">The data plane Uri.</param>
        /// <param name="controlPlaneUri">The control plane Uri.</param>
        /// <param name="processServers">The list of process servers.</param>
        /// <param name="rcmProxies">The list of RCM proxies.</param>
        /// <param name="pushInstallers">The list of push installers.</param>
        /// <param name="replicationAgents">The list of replication
        /// agents.</param>
        /// <param name="reprotectAgents">The list of reprotect agents.</param>
        /// <param name="marsAgents">The list of Mars agents.</param>
        /// <param name="dras">The list of DRAs.</param>
        /// <param name="agentDetails">The list of agent details.</param>
        public InMageRcmFabricSpecificDetails(string vmwareSiteId = default(string), string physicalSiteId = default(string), string serviceEndpoint = default(string), string serviceResourceId = default(string), string serviceContainerId = default(string), string dataPlaneUri = default(string), string controlPlaneUri = default(string), IList<ProcessServerDetails> processServers = default(IList<ProcessServerDetails>), IList<RcmProxyDetails> rcmProxies = default(IList<RcmProxyDetails>), IList<PushInstallerDetails> pushInstallers = default(IList<PushInstallerDetails>), IList<ReplicationAgentDetails> replicationAgents = default(IList<ReplicationAgentDetails>), IList<ReprotectAgentDetails> reprotectAgents = default(IList<ReprotectAgentDetails>), IList<MarsAgentDetails> marsAgents = default(IList<MarsAgentDetails>), IList<DraDetails> dras = default(IList<DraDetails>), IList<AgentDetails> agentDetails = default(IList<AgentDetails>))
        {
            VmwareSiteId = vmwareSiteId;
            PhysicalSiteId = physicalSiteId;
            ServiceEndpoint = serviceEndpoint;
            ServiceResourceId = serviceResourceId;
            ServiceContainerId = serviceContainerId;
            DataPlaneUri = dataPlaneUri;
            ControlPlaneUri = controlPlaneUri;
            ProcessServers = processServers;
            RcmProxies = rcmProxies;
            PushInstallers = pushInstallers;
            ReplicationAgents = replicationAgents;
            ReprotectAgents = reprotectAgents;
            MarsAgents = marsAgents;
            Dras = dras;
            AgentDetails = agentDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ARM Id of the VMware site.
        /// </summary>
        [JsonProperty(PropertyName = "vmwareSiteId")]
        public string VmwareSiteId { get; private set; }

        /// <summary>
        /// Gets the ARM Id of the physical site.
        /// </summary>
        [JsonProperty(PropertyName = "physicalSiteId")]
        public string PhysicalSiteId { get; private set; }

        /// <summary>
        /// Gets the service endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "serviceEndpoint")]
        public string ServiceEndpoint { get; private set; }

        /// <summary>
        /// Gets the service resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "serviceResourceId")]
        public string ServiceResourceId { get; private set; }

        /// <summary>
        /// Gets the service container Id.
        /// </summary>
        [JsonProperty(PropertyName = "serviceContainerId")]
        public string ServiceContainerId { get; private set; }

        /// <summary>
        /// Gets the data plane Uri.
        /// </summary>
        [JsonProperty(PropertyName = "dataPlaneUri")]
        public string DataPlaneUri { get; private set; }

        /// <summary>
        /// Gets the control plane Uri.
        /// </summary>
        [JsonProperty(PropertyName = "controlPlaneUri")]
        public string ControlPlaneUri { get; private set; }

        /// <summary>
        /// Gets the list of process servers.
        /// </summary>
        [JsonProperty(PropertyName = "processServers")]
        public IList<ProcessServerDetails> ProcessServers { get; private set; }

        /// <summary>
        /// Gets the list of RCM proxies.
        /// </summary>
        [JsonProperty(PropertyName = "rcmProxies")]
        public IList<RcmProxyDetails> RcmProxies { get; private set; }

        /// <summary>
        /// Gets the list of push installers.
        /// </summary>
        [JsonProperty(PropertyName = "pushInstallers")]
        public IList<PushInstallerDetails> PushInstallers { get; private set; }

        /// <summary>
        /// Gets the list of replication agents.
        /// </summary>
        [JsonProperty(PropertyName = "replicationAgents")]
        public IList<ReplicationAgentDetails> ReplicationAgents { get; private set; }

        /// <summary>
        /// Gets the list of reprotect agents.
        /// </summary>
        [JsonProperty(PropertyName = "reprotectAgents")]
        public IList<ReprotectAgentDetails> ReprotectAgents { get; private set; }

        /// <summary>
        /// Gets the list of Mars agents.
        /// </summary>
        [JsonProperty(PropertyName = "marsAgents")]
        public IList<MarsAgentDetails> MarsAgents { get; private set; }

        /// <summary>
        /// Gets the list of DRAs.
        /// </summary>
        [JsonProperty(PropertyName = "dras")]
        public IList<DraDetails> Dras { get; private set; }

        /// <summary>
        /// Gets the list of agent details.
        /// </summary>
        [JsonProperty(PropertyName = "agentDetails")]
        public IList<AgentDetails> AgentDetails { get; private set; }

    }
}
