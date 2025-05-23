using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Yarn.Models;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("patch")]
public record YarnPatchOptions(
    [property: PositionalArgument(Position = Position.BeforeSwitches)] string Package
) : YarnOptions
{
    [BooleanCommandSwitch("--update")]
    public virtual bool? Update { get; set; }

    [BooleanCommandSwitch("--json")]
    public virtual bool? Json { get; set; }
}