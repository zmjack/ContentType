﻿//<auto-generated>
namespace ContentType;

public static partial class MediaType
{
    /// <summary>
    /// Common MIME types.
    /// <para>
    /// See <see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types/Common_types"/>.
    /// </para>
    /// <para>
    /// This page was last modified on Aug 29, 2023 by MDN contributors.
    /// </para>
    /// </summary>
	public static readonly Dictionary<string, HttpMediaType> CommonTypes = new()
	{
        [".aac"] = new HttpMediaType(".aac", "AAC audio", "audio/aac"),
        [".abw"] = new HttpMediaType(".abw", "AbiWord document", "application/x-abiword"),
        [".arc"] = new HttpMediaType(".arc", "Archive document (multiple files embedded)", "application/x-freearc"),
        [".avif"] = new HttpMediaType(".avif", "AVIF image", "image/avif"),
        [".avi"] = new HttpMediaType(".avi", "AVI: Audio Video Interleave", "video/x-msvideo"),
        [".azw"] = new HttpMediaType(".azw", "Amazon Kindle eBook format", "application/vnd.amazon.ebook"),
        [".bin"] = new HttpMediaType(".bin", "Any kind of binary data", "application/octet-stream"),
        [".bmp"] = new HttpMediaType(".bmp", "Windows OS/2 Bitmap Graphics", "image/bmp"),
        [".bz"] = new HttpMediaType(".bz", "BZip archive", "application/x-bzip"),
        [".bz2"] = new HttpMediaType(".bz2", "BZip2 archive", "application/x-bzip2"),
        [".cda"] = new HttpMediaType(".cda", "CD audio", "application/x-cdf"),
        [".csh"] = new HttpMediaType(".csh", "C-Shell script", "application/x-csh"),
        [".css"] = new HttpMediaType(".css", "Cascading Style Sheets (CSS)", "text/css"),
        [".csv"] = new HttpMediaType(".csv", "Comma-separated values (CSV)", "text/csv"),
        [".doc"] = new HttpMediaType(".doc", "Microsoft Word", "application/msword"),
        [".docx"] = new HttpMediaType(".docx", "Microsoft Word (OpenXML)", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"),
        [".eot"] = new HttpMediaType(".eot", "MS Embedded OpenType fonts", "application/vnd.ms-fontobject"),
        [".epub"] = new HttpMediaType(".epub", "Electronic publication (EPUB)", "application/epub+zip"),
        [".gz"] = new HttpMediaType(".gz", "GZip Compressed Archive", "application/gzip"),
        [".gif"] = new HttpMediaType(".gif", "Graphics Interchange Format (GIF)", "image/gif"),
        [".htm"] = new HttpMediaType(".htm", "HyperText Markup Language (HTML)", "text/html"),
        [".ico"] = new HttpMediaType(".ico", "Icon format", "image/vnd.microsoft.icon"),
        [".ics"] = new HttpMediaType(".ics", "iCalendar format", "text/calendar"),
        [".jar"] = new HttpMediaType(".jar", "Java Archive (JAR)", "application/java-archive"),
        [".jpeg"] = new HttpMediaType(".jpeg", "JPEG images", "image/jpeg"),
        [".js"] = new HttpMediaType(".js", "JavaScript", "text/javascript"),
        [".json"] = new HttpMediaType(".json", "JSON format", "application/json"),
        [".jsonld"] = new HttpMediaType(".jsonld", "JSON-LD format", "application/ld+json"),
        [".mid"] = new HttpMediaType(".mid", "Musical Instrument Digital Interface (MIDI)", "audio/midi"),
        [".mjs"] = new HttpMediaType(".mjs", "JavaScript module", "text/javascript"),
        [".mp3"] = new HttpMediaType(".mp3", "MP3 audio", "audio/mpeg"),
        [".mp4"] = new HttpMediaType(".mp4", "MP4 video", "video/mp4"),
        [".mpeg"] = new HttpMediaType(".mpeg", "MPEG Video", "video/mpeg"),
        [".mpkg"] = new HttpMediaType(".mpkg", "Apple Installer Package", "application/vnd.apple.installer+xml"),
        [".odp"] = new HttpMediaType(".odp", "OpenDocument presentation document", "application/vnd.oasis.opendocument.presentation"),
        [".ods"] = new HttpMediaType(".ods", "OpenDocument spreadsheet document", "application/vnd.oasis.opendocument.spreadsheet"),
        [".odt"] = new HttpMediaType(".odt", "OpenDocument text document", "application/vnd.oasis.opendocument.text"),
        [".oga"] = new HttpMediaType(".oga", "OGG audio", "audio/ogg"),
        [".ogv"] = new HttpMediaType(".ogv", "OGG video", "video/ogg"),
        [".ogx"] = new HttpMediaType(".ogx", "OGG", "application/ogg"),
        [".opus"] = new HttpMediaType(".opus", "Opus audio", "audio/opus"),
        [".otf"] = new HttpMediaType(".otf", "OpenType font", "font/otf"),
        [".png"] = new HttpMediaType(".png", "Portable Network Graphics", "image/png"),
        [".pdf"] = new HttpMediaType(".pdf", "Adobe Portable Document Format (PDF)", "application/pdf"),
        [".php"] = new HttpMediaType(".php", "Hypertext Preprocessor (Personal Home Page)", "application/x-httpd-php"),
        [".ppt"] = new HttpMediaType(".ppt", "Microsoft PowerPoint", "application/vnd.ms-powerpoint"),
        [".pptx"] = new HttpMediaType(".pptx", "Microsoft PowerPoint (OpenXML)", "application/vnd.openxmlformats-officedocument.presentationml.presentation"),
        [".rar"] = new HttpMediaType(".rar", "RAR archive", "application/vnd.rar"),
        [".rtf"] = new HttpMediaType(".rtf", "Rich Text Format (RTF)", "application/rtf"),
        [".sh"] = new HttpMediaType(".sh", "Bourne shell script", "application/x-sh"),
        [".svg"] = new HttpMediaType(".svg", "Scalable Vector Graphics (SVG)", "image/svg+xml"),
        [".tar"] = new HttpMediaType(".tar", "Tape Archive (TAR)", "application/x-tar"),
        [".tif"] = new HttpMediaType(".tif", "Tagged Image File Format (TIFF)", "image/tiff"),
        [".ts"] = new HttpMediaType(".ts", "MPEG transport stream", "video/mp2t"),
        [".ttf"] = new HttpMediaType(".ttf", "TrueType Font", "font/ttf"),
        [".txt"] = new HttpMediaType(".txt", "Text, (generally ASCII or ISO 8859-n)", "text/plain"),
        [".vsd"] = new HttpMediaType(".vsd", "Microsoft Visio", "application/vnd.visio"),
        [".wav"] = new HttpMediaType(".wav", "Waveform Audio Format", "audio/wav"),
        [".weba"] = new HttpMediaType(".weba", "WEBM audio", "audio/webm"),
        [".webm"] = new HttpMediaType(".webm", "WEBM video", "video/webm"),
        [".webp"] = new HttpMediaType(".webp", "WEBP image", "image/webp"),
        [".woff"] = new HttpMediaType(".woff", "Web Open Font Format (WOFF)", "font/woff"),
        [".woff2"] = new HttpMediaType(".woff2", "Web Open Font Format (WOFF)", "font/woff2"),
        [".xhtml"] = new HttpMediaType(".xhtml", "XHTML", "application/xhtml+xml"),
        [".xls"] = new HttpMediaType(".xls", "Microsoft Excel", "application/vnd.ms-excel"),
        [".xlsx"] = new HttpMediaType(".xlsx", "Microsoft Excel (OpenXML)", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"),
        [".xml"] = new HttpMediaType(".xml", "XML", "application/xml"),
        [".xul"] = new HttpMediaType(".xul", "XUL", "application/vnd.mozilla.xul+xml"),
        [".zip"] = new HttpMediaType(".zip", "ZIP archive", "application/zip"),
        [".3gp"] = new HttpMediaType(".3gp", "3GPP audio/video container", "video/3gpp"),
        [".3g2"] = new HttpMediaType(".3g2", "3GPP2 audio/video container", "video/3gpp2"),
        [".7z"] = new HttpMediaType(".7z", "7-zip archive", "application/x-7z-compressed"),
    };
}