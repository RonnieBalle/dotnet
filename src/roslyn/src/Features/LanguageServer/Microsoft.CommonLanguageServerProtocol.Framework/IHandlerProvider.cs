﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;

namespace Microsoft.CommonLanguageServerProtocol.Framework;

/// <summary>
/// Manages handler discovery and distribution.
/// </summary>
public interface IHandlerProvider
{
    ImmutableArray<RequestHandlerMetadata> GetRegisteredMethods();

    IMethodHandler GetMethodHandler(string method, Type? requestType, Type? responseType);
}
