// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of instance failover groups. </summary>
    internal partial class InstanceFailoverGroupListResult
    {
        /// <summary> Initializes a new instance of InstanceFailoverGroupListResult. </summary>
        internal InstanceFailoverGroupListResult()
        {
            Value = new ChangeTrackingList<InstanceFailoverGroup>();
        }

        /// <summary> Initializes a new instance of InstanceFailoverGroupListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal InstanceFailoverGroupListResult(IReadOnlyList<InstanceFailoverGroup> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<InstanceFailoverGroup> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
