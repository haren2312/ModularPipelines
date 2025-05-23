using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Docker.Options;

[ExcludeFromCodeCoverage]
public record DockerNodeRmOptions : DockerOptions
{
    public DockerNodeRmOptions(
        IEnumerable<string> node
    )
    {
        CommandParts = ["node", "rm"];

        Node = node;
    }

    [PositionalArgument(Position = Position.AfterSwitches)]
    public IEnumerable<string>? Node { get; set; }

    [BooleanCommandSwitch("--force")]
    public virtual bool? Force { get; set; }
}
