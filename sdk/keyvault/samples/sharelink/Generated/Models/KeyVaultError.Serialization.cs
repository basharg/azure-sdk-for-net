// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    internal partial class KeyVaultError
    {
        internal static KeyVaultError DeserializeKeyVaultError(JsonElement element)
        {
            Optional<Error> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    error = Error.DeserializeError(property.Value);
                    continue;
                }
            }
            return new KeyVaultError(error.Value);
        }
    }
}