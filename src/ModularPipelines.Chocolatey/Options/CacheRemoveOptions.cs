using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Chocolatey.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cache", "remove")]
public record CacheRemoveOptions : ChocoOptions
{
    [BooleanCommandSwitch("--expired")]
    public virtual bool? Expired { get; set; }
}