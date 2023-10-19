# ContentType
ContentType definitions for HTTP.

<br/>

## Install

```powershell
dotnet add package ContentType
```

<br/>

## Use

Simply use:

```csharp
var mediaType = MediaType.Parse("application.doc");
Console.WriteLine(mediaType.MimeType);
```

> application/msword

<br/>

```csharp
var mediaTypes = MediaType.EnumTypes("image/jpeg");
foreach(var mediaType in mediaTypes)
{
	Console.WriteLine(mediaType.MimeType);
}
```

> .jpeg<br/>
>
> .jpg

<br/>