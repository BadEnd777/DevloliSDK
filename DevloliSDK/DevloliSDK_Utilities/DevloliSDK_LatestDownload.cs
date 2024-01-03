using UnityEditor;
using UnityEngine;


public partial class DevloliSDK_Download : EditorWindow
{
    [MenuItem("DevloliSDK/Utilities/DevloliSDK Latest Version")]
    public static void DownloadDevloliSDK()
    {
        Application.OpenURL("https://devloli-main.github.io/sdk/DevloliSDK.unitypackage");
    }
}
