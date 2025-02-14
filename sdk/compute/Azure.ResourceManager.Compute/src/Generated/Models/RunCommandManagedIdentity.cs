// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Contains clientId or objectId (use only one, not both) of a user-assigned managed identity that has access to storage blob used in Run Command. Use an empty RunCommandManagedIdentity object in case of system-assigned identity. Make sure the Azure storage blob exists in case of scriptUri, and managed identity has been given access to blob&apos;s container with &apos;Storage Blob Data Reader&apos; role assignment with scriptUri blob and &apos;Storage Blob Data Contributor&apos; for Append blobs(outputBlobUri, errorBlobUri). In case of user assigned identity, make sure you add it under VM&apos;s identity. For more info on managed identity and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged. </summary>
    public partial class RunCommandManagedIdentity
    {
        /// <summary> Initializes a new instance of RunCommandManagedIdentity. </summary>
        public RunCommandManagedIdentity()
        {
        }

        /// <summary> Initializes a new instance of RunCommandManagedIdentity. </summary>
        /// <param name="clientId"> Client Id (GUID value) of the user-assigned managed identity. ObjectId should not be used if this is provided. </param>
        /// <param name="objectId"> Object Id (GUID value) of the user-assigned managed identity. ClientId should not be used if this is provided. </param>
        internal RunCommandManagedIdentity(string clientId, string objectId)
        {
            ClientId = clientId;
            ObjectId = objectId;
        }

        /// <summary> Client Id (GUID value) of the user-assigned managed identity. ObjectId should not be used if this is provided. </summary>
        public string ClientId { get; set; }
        /// <summary> Object Id (GUID value) of the user-assigned managed identity. ClientId should not be used if this is provided. </summary>
        public string ObjectId { get; set; }
    }
}
