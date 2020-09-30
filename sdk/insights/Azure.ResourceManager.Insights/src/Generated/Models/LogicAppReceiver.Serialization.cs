// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class LogicAppReceiver : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("resourceId");
            writer.WriteStringValue(ResourceId);
            writer.WritePropertyName("callbackUrl");
            writer.WriteStringValue(CallbackUrl);
            writer.WritePropertyName("useCommonAlertSchema");
            writer.WriteBooleanValue(UseCommonAlertSchema);
            writer.WriteEndObject();
        }

        internal static LogicAppReceiver DeserializeLogicAppReceiver(JsonElement element)
        {
            string name = default;
            string resourceId = default;
            string callbackUrl = default;
            bool useCommonAlertSchema = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callbackUrl"))
                {
                    callbackUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"))
                {
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
            }
            return new LogicAppReceiver(name, resourceId, callbackUrl, useCommonAlertSchema);
        }
    }
}