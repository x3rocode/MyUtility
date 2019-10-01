using UnityEngine;

/// <summary>
/// 경로 설정용.
/// </summary>
public static class PathExtend
{
    /// <summary>
    /// A/B/C.prefab => C:\project\Assets/A/B/C.prefab
    /// </summary>
    /// <param name="assetPath"></param>
    /// <returns></returns>
    public static string GetFullPath(string assetPath)
    {
        assetPath = assetPath.Replace(@"\", "/"); 
        assetPath = UnityEngine.Application.dataPath.Replace(@"\", "/") + $"/{assetPath}";
        return assetPath;
    }

    /// <summary>
    /// c:\project/Assets/A/B => Assets/A/B
    /// </summary>
    /// <param name="fullPath"></param>
    /// <returns></returns>
    public static string FullPathToPorjectPath(string fullPath)
    {
        fullPath = fullPath.Replace(@"\", "/");
        var assetPath = UnityEngine.Application.dataPath.Replace(@"\", "/") + "/";
        fullPath = fullPath.Replace(assetPath, null);
        return $"Assets/{fullPath}";
    }
}
