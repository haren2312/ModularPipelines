using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Yarn.Models;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("plugin", "check")]
public record YarnPluginCheckOptions : YarnOptions
{
    [BooleanCommandSwitch("--json")]
    public virtual bool? Json { get; set; }
}