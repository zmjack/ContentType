namespace ContentType;

public static partial class MediaType
{
    public static HttpMediaType Parse(string fileName)
    {
        var ext = Path.GetExtension(fileName).ToLower();
        if (CommonTypes.ContainsKey(ext)) return CommonTypes[ext];
        else if (OtherTypes.ContainsKey(ext)) return OtherTypes[ext];
        else return HttpMediaType.OctetStream;
    }

    public static IEnumerable<HttpMediaType> All
    {
        get
        {
            foreach (var value in CommonTypes.Values)
            {
                yield return value;
            }
            foreach (var value in OtherTypes.Values)
            {
                yield return value;
            }
        }
    }

    public static IEnumerable<HttpMediaType> AudioTypes => All.Where(x => x.MimeType.StartsWith("audio"));
    public static IEnumerable<HttpMediaType> ApplicationTypes => All.Where(x => x.MimeType.StartsWith("application"));
    public static IEnumerable<HttpMediaType> ImageTypes => All.Where(x => x.MimeType.StartsWith("image"));
    public static IEnumerable<HttpMediaType> VideoTypes => All.Where(x => x.MimeType.StartsWith("video"));
    public static IEnumerable<HttpMediaType> TextTypes => All.Where(x => x.MimeType.StartsWith("text"));
    public static IEnumerable<HttpMediaType> FontTypes => All.Where(x => x.MimeType.StartsWith("font"));

    public static IEnumerable<HttpMediaType> EnumTypes(string mimeType)
    {
        IEnumerable<HttpMediaType> Enum()
        {
            if (mimeType == "application/octet-stream")
            {
                yield return HttpMediaType.OctetStream;
            }
            else
            {
                foreach (var value in CommonTypes.Values.Where(x => x.MimeType == mimeType))
                {
                    yield return value;
                }
                foreach (var value in OtherTypes.Values.Where(x => x.MimeType == mimeType))
                {
                    yield return value;
                }
            }
        }
        return Enum();
    }

    public static readonly Dictionary<string, HttpMediaType> OtherTypes = new()
    {
        [".jpg"] = new HttpMediaType(".jpg", "JPEG images", "image/jpeg"),
        [".html"] = new HttpMediaType(".html", "HyperText Markup Language (HTML)", "text/html"),
    };
}
