using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Terraform.Options;

[CommandPrecedingArguments("terraform providers schema")]
[ExcludeFromCodeCoverage]
public record TerraformTerraformProvidersSchemaOptions : TerraformOptions
{
    [BooleanCommandSwitch("-json")]
    public virtual bool? Json { get; set; }
}