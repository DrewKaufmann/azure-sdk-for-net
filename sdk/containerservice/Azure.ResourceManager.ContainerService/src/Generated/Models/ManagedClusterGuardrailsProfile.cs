// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The Guardrails profile. </summary>
    public partial class ManagedClusterGuardrailsProfile
    {
        /// <summary> Initializes a new instance of ManagedClusterGuardrailsProfile. </summary>
        /// <param name="version"> The version of constraints to use. </param>
        /// <param name="level"> The guardrails level to be used. By default, Guardrails is enabled for all namespaces except those that AKS excludes via systemExcludedNamespaces. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public ManagedClusterGuardrailsProfile(string version, ManagedClusterGuardrailsProfileLevel level)
        {
            Argument.AssertNotNull(version, nameof(version));

            SystemExcludedNamespaces = new ChangeTrackingList<string>();
            Version = version;
            Level = level;
            ExcludedNamespaces = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ManagedClusterGuardrailsProfile. </summary>
        /// <param name="systemExcludedNamespaces"> List of namespaces specified by AKS to be excluded from Guardrails. </param>
        /// <param name="version"> The version of constraints to use. </param>
        /// <param name="level"> The guardrails level to be used. By default, Guardrails is enabled for all namespaces except those that AKS excludes via systemExcludedNamespaces. </param>
        /// <param name="excludedNamespaces"> List of namespaces excluded from guardrails checks. </param>
        internal ManagedClusterGuardrailsProfile(IReadOnlyList<string> systemExcludedNamespaces, string version, ManagedClusterGuardrailsProfileLevel level, IList<string> excludedNamespaces)
        {
            SystemExcludedNamespaces = systemExcludedNamespaces;
            Version = version;
            Level = level;
            ExcludedNamespaces = excludedNamespaces;
        }

        /// <summary> List of namespaces specified by AKS to be excluded from Guardrails. </summary>
        public IReadOnlyList<string> SystemExcludedNamespaces { get; }
        /// <summary> The version of constraints to use. </summary>
        public string Version { get; set; }
        /// <summary> The guardrails level to be used. By default, Guardrails is enabled for all namespaces except those that AKS excludes via systemExcludedNamespaces. </summary>
        public ManagedClusterGuardrailsProfileLevel Level { get; set; }
        /// <summary> List of namespaces excluded from guardrails checks. </summary>
        public IList<string> ExcludedNamespaces { get; }
    }
}
