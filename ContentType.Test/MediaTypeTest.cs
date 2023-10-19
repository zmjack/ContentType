namespace ContentType.Test;

public class MediaTypeTest
{
    [Fact]
    public void Test1()
    {
        var excel = MediaType.Parse("excel.xlsx");
        Assert.Equal("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excel.ToString());
    }
}