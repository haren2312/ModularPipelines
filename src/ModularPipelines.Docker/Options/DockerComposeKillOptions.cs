using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Docker.Options;

[CommandPrecedingArguments("compose", "kill")]
[ExcludeFromCodeCoverage]
public record DockerComposeKillOptions : DockerOptions
{
    [PositionalArgument(Position = Position.AfterSwitches)]
    public IEnumerable<string>? Service { get; set; }

    [BooleanCommandSwitch("--remove-orphans")]
    public virtual bool? RemoveOrphans { get; set; }

    [CommandSwitch("--signal")]
    public virtual string? Signal { get; set; }
}
