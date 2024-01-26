using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.FileProviders;
using System.Security.Cryptography;

namespace BlazorAppSsrWasm.Services;

public class UiFileService(IMemoryCache memoryCache, IWebHostEnvironment webHostEnvironment)
{
    private static readonly object UiFileLock = new();

    public string GetCacheBustString(string webPath)
    {
        if (!memoryCache.TryGetValue(webPath, out string? cacheBustStringTry1))
        {
            lock (UiFileLock)
            {
                if (!memoryCache.TryGetValue(webPath, out string? cacheBustStringTry2))
                {
                    var fileSystemStylePath = webPath.Trim('/').Replace('/', Path.DirectorySeparatorChar);
                    var fileInfo = new FileInfo(Path.Combine(webHostEnvironment.WebRootPath, fileSystemStylePath));
                    var fileProvider = new PhysicalFileProvider(fileInfo.Directory!.FullName);
                    var token = fileProvider.Watch(fileInfo.Name);
                    var cacheEntryOptions = new MemoryCacheEntryOptions().AddExpirationToken(token);
                    using var md5 = MD5.Create();
                    using var stream = File.OpenRead(fileInfo.FullName);
                    var hash = md5.ComputeHash(stream);
                    cacheBustStringTry1 = cacheBustStringTry2 = BitConverter.ToString(hash).Replace("-", string.Empty).ToLowerInvariant();
                    memoryCache.Set(webPath, cacheBustStringTry2, cacheEntryOptions);
                }
            }
        }

        return cacheBustStringTry1 ?? string.Empty;
    }
}
