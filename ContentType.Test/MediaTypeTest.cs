namespace ContentType.Test;

public class MediaTypeTest
{
    [Fact]
    public void Test1()
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
}
