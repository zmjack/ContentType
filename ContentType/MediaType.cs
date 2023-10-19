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

    public static readonly Dictionary<string, HttpMediaType> OtherTypes = new()
    {
        [".jpg"] = new HttpMediaType(".jpg", "JPEG images", "image/jpeg"),
    };
}
