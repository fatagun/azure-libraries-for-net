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
    using System.Linq;

    /// <summary>
    /// Source control configuration for an app.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SiteSourceControlInner : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the SiteSourceControlInner class.
        /// </summary>
        public SiteSourceControlInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteSourceControlInner class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="repoUrl">Repository or source control URL.</param>
        /// <param name="branch">Name of branch to use for deployment.</param>
        /// <param name="isManualIntegration">&lt;code&gt;true&lt;/code&gt; to
        /// limit to manual integration; &lt;code&gt;false&lt;/code&gt; to
        /// enable continuous integration (which configures webhooks into
        /// online repos like GitHub).</param>
        /// <param
        /// name="deploymentRollbackEnabled">&lt;code&gt;true&lt;/code&gt; to
        /// enable deployment rollback; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="isMercurial">&lt;code&gt;true&lt;/code&gt; for a
        /// Mercurial repository; &lt;code&gt;false&lt;/code&gt; for a Git
        /// repository.</param>
        public SiteSourceControlInner(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string repoUrl = default(string), string branch = default(string), bool? isManualIntegration = default(bool?), bool? deploymentRollbackEnabled = default(bool?), bool? isMercurial = default(bool?))
            : base(id, name, kind, type)
        {
            RepoUrl = repoUrl;
            Branch = branch;
            IsManualIntegration = isManualIntegration;
            DeploymentRollbackEnabled = deploymentRollbackEnabled;
            IsMercurial = isMercurial;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets repository or source control URL.
        /// </summary>
        [JsonProperty(PropertyName = "properties.repoUrl")]
        public string RepoUrl { get; set; }

        /// <summary>
        /// Gets or sets name of branch to use for deployment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to limit
        /// to manual integration;
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt; to enable continuous
        /// integration (which configures webhooks into online repos like
        /// GitHub).
        /// </summary>
        [JsonProperty(PropertyName = "properties.isManualIntegration")]
        public bool? IsManualIntegration { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to
        /// enable deployment rollback; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deploymentRollbackEnabled")]
        public bool? DeploymentRollbackEnabled { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; for a
        /// Mercurial repository;
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt; for a Git
        /// repository.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isMercurial")]
        public bool? IsMercurial { get; set; }

    }
}
