// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A Class representing a TenantPolicySetDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TenantPolicySetDefinitionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTenantPolicySetDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetTenantPolicySetDefinition method.
    /// </summary>
    public partial class TenantPolicySetDefinitionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantPolicySetDefinitionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string policySetDefinitionName)
        {
            var resourceId = $"/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics;
        private readonly PolicySetDefinitionsRestOperations _tenantPolicySetDefinitionPolicySetDefinitionsRestClient;
        private readonly PolicySetDefinitionData _data;

        /// <summary> Initializes a new instance of the <see cref="TenantPolicySetDefinitionResource"/> class for mocking. </summary>
        protected TenantPolicySetDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TenantPolicySetDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantPolicySetDefinitionResource(ArmClient client, PolicySetDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TenantPolicySetDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantPolicySetDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantPolicySetDefinitionPolicySetDefinitionsApiVersion);
            _tenantPolicySetDefinitionPolicySetDefinitionsRestClient = new PolicySetDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantPolicySetDefinitionPolicySetDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policySetDefinitions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicySetDefinitionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// This operation retrieves the built-in policy set definition with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_GetBuiltIn</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantPolicySetDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("TenantPolicySetDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _tenantPolicySetDefinitionPolicySetDefinitionsRestClient.GetBuiltInAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantPolicySetDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the built-in policy set definition with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_GetBuiltIn</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantPolicySetDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("TenantPolicySetDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _tenantPolicySetDefinitionPolicySetDefinitionsRestClient.GetBuiltIn(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantPolicySetDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
