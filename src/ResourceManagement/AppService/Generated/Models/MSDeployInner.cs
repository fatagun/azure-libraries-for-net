// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// MSDeploy ARM PUT information
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MSDeployInner : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the MSDeployInner class.
        /// </summary>
        public MSDeployInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MSDeployInner class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="packageUri">Package URI</param>
        /// <param name="connectionString">SQL Connection String</param>
        /// <param name="dbType">Database Type</param>
        /// <param name="setParametersXmlFileUri">URI of MSDeploy Parameters
        /// file. Must not be set if SetParameters is used.</param>
        /// <param name="setParameters">MSDeploy Parameters. Must not be set if
        /// SetParametersXmlFileUri is used.</param>
        /// <param name="skipAppData">Controls whether the MSDeploy operation
        /// skips the App_Data directory.
        /// If set to &lt;code&gt;true&lt;/code&gt;, the existing App_Data
        /// directory on the destination
        /// will not be deleted, and any App_Data directory in the source will
        /// be ignored.
        /// Setting is &lt;code&gt;false&lt;/code&gt; by default.</param>
        /// <param name="appOffline">Sets the AppOffline rule while the
        /// MSDeploy operation executes.
        /// Setting is &lt;code&gt;false&lt;/code&gt; by default.</param>
        /// <param name="addOnPackages">List of Add-On packages. Add-On
        /// packages implicitly enable the Do Not Delete MSDeploy rule.</param>
        public MSDeployInner(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string packageUri = default(string), string connectionString = default(string), string dbType = default(string), string setParametersXmlFileUri = default(string), IDictionary<string, string> setParameters = default(IDictionary<string, string>), bool? skipAppData = default(bool?), bool? appOffline = default(bool?), IList<MSDeployCore> addOnPackages = default(IList<MSDeployCore>))
            : base(id, name, kind, type)
        {
            PackageUri = packageUri;
            ConnectionString = connectionString;
            DbType = dbType;
            SetParametersXmlFileUri = setParametersXmlFileUri;
            SetParameters = setParameters;
            SkipAppData = skipAppData;
            AppOffline = appOffline;
            AddOnPackages = addOnPackages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets package URI
        /// </summary>
        [JsonProperty(PropertyName = "properties.packageUri")]
        public string PackageUri { get; set; }

        /// <summary>
        /// Gets or sets SQL Connection String
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets database Type
        /// </summary>
        [JsonProperty(PropertyName = "properties.dbType")]
        public string DbType { get; set; }

        /// <summary>
        /// Gets or sets URI of MSDeploy Parameters file. Must not be set if
        /// SetParameters is used.
        /// </summary>
        [JsonProperty(PropertyName = "properties.setParametersXmlFileUri")]
        public string SetParametersXmlFileUri { get; set; }

        /// <summary>
        /// Gets or sets mSDeploy Parameters. Must not be set if
        /// SetParametersXmlFileUri is used.
        /// </summary>
        [JsonProperty(PropertyName = "properties.setParameters")]
        public IDictionary<string, string> SetParameters { get; set; }

        /// <summary>
        /// Gets or sets controls whether the MSDeploy operation skips the
        /// App_Data directory.
        /// If set to &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt;, the
        /// existing App_Data directory on the destination
        /// will not be deleted, and any App_Data directory in the source will
        /// be ignored.
        /// Setting is &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt; by
        /// default.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skipAppData")]
        public bool? SkipAppData { get; set; }

        /// <summary>
        /// Gets or sets sets the AppOffline rule while the MSDeploy operation
        /// executes.
        /// Setting is &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt; by
        /// default.
        /// </summary>
        [JsonProperty(PropertyName = "properties.appOffline")]
        public bool? AppOffline { get; set; }

        /// <summary>
        /// Gets or sets list of Add-On packages. Add-On packages implicitly
        /// enable the Do Not Delete MSDeploy rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addOnPackages")]
        public IList<MSDeployCore> AddOnPackages { get; set; }

    }
}
