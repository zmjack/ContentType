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
    };
}
