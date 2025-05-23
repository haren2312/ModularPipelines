using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Docker.Options;

[ExcludeFromCodeCoverage]
public record DockerPluginCreateOptions : DockerOptions
{
    public DockerPluginCreateOptions(
        string plugin,
        string pluginDataDir
    )
    {
        CommandParts = ["plugin", "create"];

        Plugin = plugin;

        PluginDataDir = pluginDataDir;
    }

    [PositionalArgument(Position = Position.AfterSwitches)]
    public string? Plugin { get; set; }

    [PositionalArgument(Position = Position.AfterSwitches)]
    public string? PluginDataDir { get; set; }

    [BooleanCommandSwitch("--compress")]
    public virtual bool? Compress { get; set; }
}
