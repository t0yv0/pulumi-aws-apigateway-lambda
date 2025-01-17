// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Lambdaapi
{
    [LambdaapiResourceType("awslambdaapi:index:CloudfrontS3")]
    public partial class CloudfrontS3 : Pulumi.ComponentResource
    {
        /// <summary>
        /// Create a CloudfrontS3 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CloudfrontS3(string name, CloudfrontS3Args args, ComponentResourceOptions? options = null)
            : base("awslambdaapi:index:CloudfrontS3", name, args ?? new CloudfrontS3Args(), MakeResourceOptions(options, ""), remote: true)
        {
        }

        private static ComponentResourceOptions MakeResourceOptions(ComponentResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new ComponentResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = ComponentResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
    }

    public sealed class CloudfrontS3Args : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name to give the S3 bucket which this Component will create.
        /// </summary>
        [Input("bucketName", required: true)]
        public Input<string> BucketName { get; set; } = null!;

        public CloudfrontS3Args()
        {
        }
    }
}
