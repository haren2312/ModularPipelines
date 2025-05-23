using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Terraform.Options;

[CommandPrecedingArguments("destroy")]
[ExcludeFromCodeCoverage]
public record TerraformDestroyOptions : TerraformOptions
{
    [BooleanCommandSwitch("-destroy")]
    public virtual bool? Destroy { get; set; }
}