﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.IO;

namespace Microsoft.Azure.WebJobs.Extensions.ApiHub.Common
{
    /// <summary>
    /// Interface that defines the methods for working with file
    /// </summary>
    internal interface IFileAttribute
    {
        /// <summary>
        /// Path with resolution. It allows set so we can update this attribute with resolved parameters. 
        /// </summary>
        string Path { get; set; }

        /// <summary>
        /// Gets the file access
        /// </summary>
        FileAccess Access { get; }
    }
}