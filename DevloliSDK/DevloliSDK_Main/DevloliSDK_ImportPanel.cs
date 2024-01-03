using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using UnityEditor;
using UnityEngine;

public class DevloliSDKNewImporter : EditorWindow
{
    private string devloliSDK_version = "1.51";
    int toolbarInt = 0;

    [MenuItem("DevloliSDK/Main")]
    public static void Start()
    {
        DevloliSDKNewImporter window = (DevloliSDKNewImporter)EditorWindow.GetWindow(typeof(DevloliSDKNewImporter));
        window.Show();
    }

    public static string assetName = "Latest.unitypackage";

    private void OnGUI()
    {
        minSize = new Vector2(1000, 500);
        maxSize = new Vector2(1000, 500);

        GUIStyle header = new GUIStyle();
        header.fontSize = 25;
        header.normal.textColor = Color.white;
        header.fontStyle = FontStyle.Bold;

        GUI.BeginGroup(new Rect(0, 0, 1000, 700));
        GUI.Box(new Rect(10, 10, 1000, 700), $"DevloliSDK {devloliSDK_version}", header);
        GUI.contentColor = toolbarInt == 0 ? Color.red : Color.white;
        if (GUI.Button(new Rect(10, 50, 190, 50), (toolbarInt == 0) ? "> Screen Shaders <" : "Screen Shaders"))
        {
            toolbarInt = 0;
        }
        GUI.contentColor = toolbarInt == 1 ? Color.red : Color.white;
        if (GUI.Button(new Rect(10, 110, 190, 50), (toolbarInt == 1) ? "> Avatar Shaders <" : "Avatar Shaders"))
        {
            toolbarInt = 1;
        }
        GUI.contentColor = toolbarInt == 2 ? Color.red : Color.white;
        if (GUI.Button(new Rect(10, 170, 190, 50), (toolbarInt == 2) ? "> Avatar Assets <" : "Avatar Assets"))
        {
            toolbarInt = 2;
        }
        GUI.contentColor = toolbarInt == 3 ? Color.red : Color.white;
        if (GUI.Button(new Rect(10, 230, 190, 50), (toolbarInt == 3) ? "> Tools <" : "Tools"))
        {
            toolbarInt = 3;
        }
        GUI.contentColor = toolbarInt == 4 ? Color.red : Color.white;
        if (GUI.Button(new Rect(10, 290, 190, 50), (toolbarInt == 4) ? "> Assets Website <" : "Assets Website"))
        {
            toolbarInt = 4;
        }

        GUI.DrawTexture(new Rect(5, 300, 200, 200), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Dll.png", typeof(Texture2D)));

        GUI.contentColor = Color.white;
        if (GUI.Button(new Rect(10, 450, 90, 20), "Github"))
        {
            Application.OpenURL("https://github.com/devloli-main");
        }

        if (GUI.Button(new Rect(110, 450, 90, 20), "Website"))
        {
            Application.OpenURL("https://devloli-main.github.io/sdk/");
        }

        if (GUI.Button(new Rect(10, 475, 190, 20), "Discord Server"))
        {
            Application.OpenURL("https://discord.gg/6Dm65wmuXg");
        }

        switch (toolbarInt)
        {
            case 0: ScreenShaders(); break;
            case 1: AvatarShaders(); break;
            case 2: AvatarAssets(); break;
            case 3: Tools(); break;
            case 4: AssetsWebsite(); break;
        }
        GUI.EndGroup();
    }

    // Screen Shaders
    void ScreenShaders()
    {
        GUIStyle header = new GUIStyle();
        header.fontSize = 25;
        header.normal.textColor = Color.white;
        header.fontStyle = FontStyle.Bold;

        GUI.BeginGroup(new Rect(210, 0, 770, 700));
        GUI.Box(new Rect(10, 10, 770, 700), "Screen Shaders", header);

        GUI.DrawTexture(new Rect(100, 50, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Doc's.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(100, 230, 180, 30), "DocMe Amazing 0.4"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984086763096141845/Patreon_DocMe_Amazing_0.4_fix.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(290, 50, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Doppel's.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(290, 230, 180, 30), "Dope Shaders 2.2.6"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984086761774932028/Doppelganger_Patreon_Dope_Shader_2.20.6.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(480, 50, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Leviant.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(480, 230, 180, 30), "Leviant 2.9"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984086762324381696/Leviant_ScreenSpace_Ubershader_v2.9.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(195, 280, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Doppel's.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(195, 460, 180, 30), "Dope Textures 1.0.2"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984086762001403934/Doppelganger_texture_1.0.2.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(385, 280, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Mochies.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(385, 460, 180, 30), "Mochies 1.5"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984086762605395968/Mochies_Screen_FX_v1.5.unitypackage"), assetName);
        }

        GUI.EndGroup();
    }

    // Avatar Shaders
    void AvatarShaders()
    {
        GUIStyle header = new GUIStyle();
        header.fontSize = 25;
        header.normal.textColor = Color.white;
        header.fontStyle = FontStyle.Bold;

        GUI.BeginGroup(new Rect(210, 0, 770, 700));
        GUI.Box(new Rect(10, 10, 770, 700), "Avatar Shaders", header);

        GUI.DrawTexture(new Rect(10, 50, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Doppel's.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(10, 230, 180, 30), "Dope Toon 1.4.0"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984087418837807114/Doppelganger_Patreon_Dope_Toon_1.4.0.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(195, 50, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/iliToon.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(195, 230, 180, 30), "iLiToon 1.2.12"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984087419605360640/lilToon_1.2.12.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(385, 50, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/err.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(385, 230, 180, 30), "LyumaShader 1.1.2"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984087419827666944/LyumaShader-v1.1.2.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(570, 50, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Poi.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(570, 230, 180, 30), "Poiyumi Pro 8.0.068"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984087420511326258/PoiyomiPro8.0.068_and_7.3.46.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(100, 280, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Reflex.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(100, 460, 180, 30), "ReflexShader 2.2.0"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984087422998556752/ReflexShader-2-2-0.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(290, 280, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Sunao.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(290, 460, 180, 30), "SunaoShader 1.6.1"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984087424051314739/SunaoShader_1_6_1.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(480, 280, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Unity.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(480, 460, 180, 30), "UTS2 ShaderOnly 2.0.9"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984087424714031144/UTS2_ShaderOnly_v2.0.9_Release.unitypackage"), assetName);
        }

        GUI.EndGroup();
    }

    // Avatar Assets
    void AvatarAssets()
    {
        GUIStyle header = new GUIStyle();
        header.fontSize = 25;
        header.normal.textColor = Color.white;
        header.fontStyle = FontStyle.Bold;

        GUI.BeginGroup(new Rect(210, 0, 770, 700));
        GUI.Box(new Rect(10, 10, 770, 700), "Avatar Assets", header);

        GUI.DrawTexture(new Rect(195, 150, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Manish.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(195, 330, 180, 30), "MatPack 1 By Manish"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984096879312781342/MatPack_1_by_Manish.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(385, 150, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Manish.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(385, 330, 180, 30), "MatPack 2 By Manish"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984096880554278912/MatPack_2_by_Manish.unitypackage"), assetName);
        }

        GUI.EndGroup();
    }

    // Tools
    void Tools()
    {
        GUIStyle header = new GUIStyle();
        header.fontSize = 25;
        header.normal.textColor = Color.white;
        header.fontStyle = FontStyle.Bold;

        GUI.BeginGroup(new Rect(210, 0, 770, 700));
        GUI.Box(new Rect(10, 10, 770, 700), "Avatar Tools", header);

        // image group 5 images
        GUI.DrawTexture(new Rect(10, 90, 140, 140), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/err.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(10, 230, 140, 30), "AnimationKeyPanel"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984103399366750268/2019_Animation_Sound_Key_Panel.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(160, 90, 140, 140), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/err.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(160, 230, 140, 30), "AvatarTools 2.1.3"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984103399597441024/AvatarTools_v2.1.3.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(310, 90, 140, 140), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/err.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(310, 230, 140, 30), "CGE 2.0.2"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984103399874244648/CGE_V2.0.2.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(460, 90, 140, 140), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/DynamicBone.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(460, 230, 140, 30), "DynamicBone 1.3.2"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984103400281088010/Dynamic_Bone_v1.3.2.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(610, 90, 140, 140), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/err.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(610, 230, 140, 30), "LoadBundle"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984103400637624380/LoadBundle.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(10, 290, 140, 140), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/err.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(10, 430, 140, 30), "Pumkins 1.1.1"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984103400851537930/PumkinsAvatarTools_v1.1.1.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(160, 290, 140, 140), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/err.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(160, 430, 140, 30), "QHierarchy"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984103401241595934/QHierarchy.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(310, 290, 140, 140), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/err.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(310, 430, 140, 30), "WorldAudio"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984103401480654878/WorldAudio.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(460, 290, 140, 140), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/err.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(460, 430, 140, 30), "WorldConstraints"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984103401682006026/worldConstraints.unitypackage"), assetName);
        }

        GUI.DrawTexture(new Rect(610, 290, 140, 140), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Questtools.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(610, 430, 140, 30), "Questtools"))
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/958735502910054510/984103401895919626/VRCQuestTools-v1.6.2.unitypackage"), assetName);
        }

        GUI.EndGroup();
    }

    // Assets Website
    void AssetsWebsite()
    {
        GUIStyle header = new GUIStyle();
        header.fontSize = 25;
        header.normal.textColor = Color.white;
        header.fontStyle = FontStyle.Bold;

        GUI.BeginGroup(new Rect(210, 0, 770, 700));
        GUI.Box(new Rect(10, 10, 770, 700), "Assets Website", header);

        GUI.DrawTexture(new Rect(100, 50, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/VRM.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(100, 230, 180, 30), "VRC Models"))
        {
            Application.OpenURL("https://vrmodels.store/");
        }

        GUI.DrawTexture(new Rect(290, 50, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/VRCMods.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(290, 230, 180, 30), "VRC Mods"))
        {
            Application.OpenURL("https://vrcmods.com/");
        }

        GUI.DrawTexture(new Rect(480, 50, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Jinxxy.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(480, 230, 180, 30), "Jinxxy"))
        {
            Application.OpenURL("https://jinxxy.com/market/products");
        }

        GUI.DrawTexture(new Rect(195, 280, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/Mixamo.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(195, 460, 180, 30), "Mixamo"))
        {
            Application.OpenURL("https://www.mixamo.com/#/");
        }

        GUI.DrawTexture(new Rect(385, 280, 180, 180), (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/VRCSDK/DevloliSDK/Resources/Import/sketchfab.png", typeof(Texture2D)));
        if (GUI.Button(new Rect(385, 460, 180, 30), "Sketchfab"))
        {
            Application.OpenURL("https://sketchfab.com/");
        }

        GUI.EndGroup();
    }

    private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
    {
        if (e.Error == null)
        {
            Process.Start(assetName);
        }
        else
        {
            UnityEngine.Debug.Log("Failed to Download" + assetName);
        }
    }
    private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
        var progress = e.ProgressPercentage;
        if (progress < 0) return;
        if (progress >= 100)
        {
            EditorUtility.ClearProgressBar();
        }
        else
        {
            EditorUtility.DisplayProgressBar("Download of" + assetName, "Downloading" + assetName + "%", (progress / 100F));
        }
    }
}
