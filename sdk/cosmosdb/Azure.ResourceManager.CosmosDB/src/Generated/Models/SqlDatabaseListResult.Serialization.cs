// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class SqlDatabaseListResult
    {
        internal static SqlDatabaseListResult DeserializeSqlDatabaseListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SqlDatabaseGetResults>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<SqlDatabaseGetResults> array = new List<SqlDatabaseGetResults>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlDatabaseGetResults.DeserializeSqlDatabaseGetResults(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SqlDatabaseListResult(Optional.ToList(value));
        }
    }
}