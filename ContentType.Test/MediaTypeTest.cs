namespace ContentType.Test;

public class MediaTypeTest
{
    [Fact]
    public void ParseTest()
    {
        Assert.Equal("application/msword", MediaType.Parse("application.doc").ToString());
        Assert.Equal("application/vnd.ms-excel", MediaType.Parse("application.xls").ToString());
        Assert.Equal("application/vnd.ms-powerpoint", MediaType.Parse("application.ppt").ToString());

        Assert.Equal("application/vnd.openxmlformats-officedocument.wordprocessingml.document", MediaType.Parse("application.docx").ToString());
        Assert.Equal("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", MediaType.Parse("application.xlsx").ToString());
        Assert.Equal("application/vnd.openxmlformats-officedocument.presentationml.presentation", MediaType.Parse("application.pptx").ToString());

        Assert.Equal("application/zip", MediaType.Parse("application.zip").ToString());

        Assert.Equal("image/png", MediaType.Parse("image.png").ToString());
        Assert.Equal("image/jpeg", MediaType.Parse("image.jpeg").ToString());
        Assert.Equal("image/jpeg", MediaType.Parse("image.jpg").ToString());
        Assert.Equal("image/gif", MediaType.Parse("image.gif").ToString());
        Assert.Equal("image/bmp", MediaType.Parse("image.bmp").ToString());

        Assert.Equal("application/octet-stream", MediaType.Parse("unknown.xxx").ToString());
    }

    [Fact]
    public void EnumTest()
    {
        var types = MediaType.All.Select(x => x.MimeType.Split('/')[0]).Distinct().ToArray();

        Assert.Equal(new[]
        {
            new HttpMediaType(".jpeg", "JPEG images", "image/jpeg"),
            new HttpMediaType(".jpg", "JPEG images", "image/jpeg"),
        }, from x in MediaType.EnumTypes("image/jpeg") select x);

        Assert.Equal(new[]
        {
            HttpMediaType.OctetStream,
        }, from x in MediaType.EnumTypes("application/octet-stream") select x);
    }

    [Fact]
    public void TypesTest()
    {
        var audioTypes = MediaType.AudioTypes.ToArray();
        var applicationTypes = MediaType.ApplicationTypes.ToArray();
        var imageTypes = MediaType.ImageTypes.ToArray();
        var videoTypes = MediaType.VideoTypes.ToArray();
        var textTypes = MediaType.TextTypes.ToArray();
        var fontTypes = MediaType.FontTypes.ToArray();

        Assert.Equal(7, audioTypes.Count());
        Assert.Equal(37, applicationTypes.Count());
        Assert.Equal(10, imageTypes.Count());
        Assert.Equal(8, videoTypes.Count());
        Assert.Equal(8, textTypes.Count());
        Assert.Equal(4, fontTypes.Count());
    }

}
