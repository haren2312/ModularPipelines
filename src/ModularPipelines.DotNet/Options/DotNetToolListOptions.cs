using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.DotNet.Options;

[ExcludeFromCodeCoverage]
public record DotNetToolListOptions : DotNetOptions
{
    public DotNetToolListOptions()
    {
        CommandParts = ["tool", "list", "[<PACKAGE_ID>]"];
    }

    public DotNetToolListOptions(
        string packageId
    )
    {
        CommandParts = ["tool", "list", "[<PACKAGE_ID>]"];

        PackageId = packageId;
    }

    [BooleanCommandSwitch("--global")]
    public virtual bool? Global { get; set; }

    [BooleanCommandSwitch("--tool-path")]
    public virtual bool? ToolPath { get; set; }

    [BooleanCommandSwitch("--local")]
    public virtual bool? Local { get; set; }

    [PositionalArgument(PlaceholderName = "[<PACKAGE_ID>]")]
    public string? PackageId { get; set; }
}
