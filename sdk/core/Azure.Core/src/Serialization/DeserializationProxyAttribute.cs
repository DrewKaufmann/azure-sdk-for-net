﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics.CodeAnalysis;

namespace Azure.Core.Serialization
{
    /// <summary>
    /// Attribute class that indicates a proxy <see cref="Type"/> to use for deserialization.
    /// The proxy <see cref="Type"/> must implement <see cref="IModelSerializable{T}"/> and have a public or non-public parameterless constructor.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class DeserializationProxyAttribute : Attribute
    {
        /// <summary>
        /// Instantiates a new instance of the <see cref="DeserializationProxyAttribute"/> class.
        /// </summary>
        /// <param name="proxyType">
        /// The <see cref="Type"/> to create and call deserialize on.
        /// The <see cref="Type"/> must have a public or non-public parameterless constructor.
        /// The <see cref="Type"/> must implement <see cref="IModelSerializable{T}"/> where T is the type of the abstract class.
        /// </param>
        public DeserializationProxyAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] Type proxyType)
        {
            ProxyType = proxyType;
        }

        /// <summary>
        /// Gets the <see cref="Type"/> to create and call deserialize on.
        /// The <see cref="Type"/> must have a public or non-public parameterless constructor.
        /// The <see cref="Type"/> must implement <see cref="IModelSerializable{T}"/> where T is the type of the abstract class.
        /// </summary>
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
        public Type ProxyType { get; }
    }
}
