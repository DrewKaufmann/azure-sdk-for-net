// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Key Vault Key Url and vault id of KeK, KeK is optional and when provided is used to unwrap the encryptionKey. </summary>
    public partial class KeyVaultAndKeyReference
    {
        /// <summary> Initializes a new instance of KeyVaultAndKeyReference. </summary>
        /// <param name="sourceVault"> Resource id of the KeyVault containing the key or secret. </param>
        /// <param name="keyUri"> Url pointing to a key or secret in KeyVault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceVault"/> or <paramref name="keyUri"/> is null. </exception>
        public KeyVaultAndKeyReference(WritableSubResource sourceVault, Uri keyUri)
        {
            Argument.AssertNotNull(sourceVault, nameof(sourceVault));
            Argument.AssertNotNull(keyUri, nameof(keyUri));

            SourceVault = sourceVault;
            KeyUri = keyUri;
        }

        /// <summary> Resource id of the KeyVault containing the key or secret. </summary>
        internal WritableSubResource SourceVault { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SourceVaultId
        {
            get => SourceVault is null ? default : SourceVault.Id;
            set
            {
                if (SourceVault is null)
                    SourceVault = new WritableSubResource();
                SourceVault.Id = value;
            }
        }

        /// <summary> Url pointing to a key or secret in KeyVault. </summary>
        public Uri KeyUri { get; set; }
    }
}
