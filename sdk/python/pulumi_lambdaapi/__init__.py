# coding=utf-8
# *** WARNING: this file was generated by Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from .cloudfront_s3 import *
from .cron_lambda import *
from .lambda_api import *
from .provider import *

def _register_module():
    import pulumi
    from . import _utilities


    class Module(pulumi.runtime.ResourceModule):
        _version = _utilities.get_semver_version()

        def version(self):
            return Module._version

        def construct(self, name: str, typ: str, urn: str) -> pulumi.Resource:
            if typ == "awslambdaapi:index:CloudfrontS3":
                return CloudfrontS3(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "awslambdaapi:index:CronLambda":
                return CronLambda(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "awslambdaapi:index:LambdaApi":
                return LambdaApi(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("lambdaapi", "index", _module_instance)


    class Package(pulumi.runtime.ResourcePackage):
        _version = _utilities.get_semver_version()

        def version(self):
            return Package._version

        def construct_provider(self, name: str, typ: str, urn: str) -> pulumi.ProviderResource:
            if typ != "pulumi:providers:lambdaapi":
                raise Exception(f"unknown provider type {typ}")
            return Provider(name, pulumi.ResourceOptions(urn=urn))


    pulumi.runtime.register_resource_package("lambdaapi", Package())

_register_module()
