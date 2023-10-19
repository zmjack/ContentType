# ContentType
ContentType definitions for HTTP.

<br/>

## Install

```powershell
dotnet add package ContentType
```

<br/>

## Use

Get **MediaType** from **FileName**:

```csharp
var mediaType = MediaType.Parse("application.doc");
Console.WriteLine(mediaType.MimeType);
```

> application/msword

<br/>

Get **MediaTypes** from **MimeType**:

```csharp
var mediaTypes = MediaType.EnumTypes("image/jpeg");
foreach(var mediaType in mediaTypes)
{
    Console.WriteLine(mediaType.Extension);
}
```

> .jpeg<br/>
>
> .jpg

<br/>

Get **MediaTypes** of the specified type:

```csharp
var audioTypes = MediaType.AudioTypes.ToArray();
var applicationTypes = MediaType.ApplicationTypes.ToArray();
var imageTypes = MediaType.ImageTypes.ToArray();
var videoTypes = MediaType.VideoTypes.ToArray();
var textTypes = MediaType.TextTypes.ToArray();
var fontTypes = MediaType.FontTypes.ToArray();
```

<br/>