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

