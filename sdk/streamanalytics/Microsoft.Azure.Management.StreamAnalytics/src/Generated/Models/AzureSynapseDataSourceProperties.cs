// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties that are associated with an Azure SQL database data
    /// source.
    /// </summary>
    public partial class AzureSynapseDataSourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the AzureSynapseDataSourceProperties
        /// class.
        /// </summary>
        public AzureSynapseDataSourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSynapseDataSourceProperties
        /// class.
        /// </summary>
        /// <param name="server">The name of the SQL server containing the
        /// Azure SQL database. Required on PUT (CreateOrReplace)
        /// requests.</param>
        /// <param name="database">The name of the Azure SQL database. Required
        /// on PUT (CreateOrReplace) requests.</param>
        /// <param name="table">The name of the table in the Azure SQL
        /// database. Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="user">The user name that will be used to connect to
        /// the Azure SQL database. Required on PUT (CreateOrReplace)
        /// requests.</param>
        /// <param name="password">The password that will be used to connect to
        /// the Azure SQL database. Required on PUT (CreateOrReplace)
        /// requests.</param>
        public AzureSynapseDataSourceProperties(string server = default(string), string database = default(string), string table = default(string), string user = default(string), string password = default(string))
        {
            Server = server;
            Database = database;
            Table = table;
            User = user;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the SQL server containing the Azure SQL
        /// database. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string Server { get; set; }

        /// <summary>
        /// Gets or sets the name of the Azure SQL database. Required on PUT
        /// (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "database")]
        public string Database { get; set; }

        /// <summary>
        /// Gets or sets the name of the table in the Azure SQL database.
        /// Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "table")]
        public string Table { get; set; }

        /// <summary>
        /// Gets or sets the user name that will be used to connect to the
        /// Azure SQL database. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the password that will be used to connect to the Azure
        /// SQL database. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
}