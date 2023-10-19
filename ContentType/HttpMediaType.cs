using System.Diagnostics;

namespace ContentType;

[DebuggerDisplay("{Extension}, {MimeType}")]
public struct HttpMediaType(string extension, string kind, string mimeType)
{
    public string Extension { get; set; } = extension;
    public string Kind { get; set; } = kind;
    public string MimeType { get; set; } = mimeType;

    public static readonly HttpMediaType OctetStream = new("", "A body contains arbitrary binary data", "application/octet-stream");

    public override string ToString() => MimeType;
}
