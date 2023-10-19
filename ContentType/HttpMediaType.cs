using System.Diagnostics;

namespace ContentType;

[DebuggerDisplay("{Extension}, {Mime}")]
public struct HttpMediaType(string extension, string kind, string mime)
{
    public string Extension { get; set; } = extension;
    public string Kind { get; set; } = kind;
    public string Mime { get; set; } = mime;

    public static readonly HttpMediaType OctetStream = new("", "A body contains arbitrary binary data", "application/octet-stream");

    public override string ToString() => Mime;
}
