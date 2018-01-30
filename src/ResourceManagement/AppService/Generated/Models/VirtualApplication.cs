// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Virtual application in an app.
    /// </summary>
    public partial class VirtualApplication
    {
        /// <summary>
        /// Initializes a new instance of the VirtualApplication class.
        /// </summary>
        public VirtualApplication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualApplication class.
        /// </summary>
        /// <param name="virtualPath">Virtual path.</param>
        /// <param name="physicalPath">Physical path.</param>
        /// <param name="preloadEnabled">&lt;code&gt;true&lt;/code&gt; if
        /// preloading is enabled; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="virtualDirectories">Virtual directories for virtual
        /// application.</param>
        public VirtualApplication(string virtualPath = default(string), string physicalPath = default(string), bool? preloadEnabled = default(bool?), IList<VirtualDirectory> virtualDirectories = default(IList<VirtualDirectory>))
        {
            VirtualPath = virtualPath;
            PhysicalPath = physicalPath;
            PreloadEnabled = preloadEnabled;
            VirtualDirectories = virtualDirectories;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets virtual path.
        /// </summary>
        [JsonProperty(PropertyName = "virtualPath")]
        public string VirtualPath { get; set; }

        /// <summary>
        /// Gets or sets physical path.
        /// </summary>
        [JsonProperty(PropertyName = "physicalPath")]
        public string PhysicalPath { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// preloading is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "preloadEnabled")]
        public bool? PreloadEnabled { get; set; }

        /// <summary>
        /// Gets or sets virtual directories for virtual application.
        /// </summary>
        [JsonProperty(PropertyName = "virtualDirectories")]
        public IList<VirtualDirectory> VirtualDirectories { get; set; }

    }
}
