using UnityEditor;
using UnityEngine;

public partial class AboutSDK : EditorWindow
{
    private string devlolisdkdiscord = "https://discord.gg/6Dm65wmuXg";
    private string devlolisdkwebsite = "https://devloli-main.github.io/sdk/";
    private string devloliupdate = "https://devloli-main.github.io/sdk/DevloliSDK.unitypackage";
    private string learn_more = "https://discord.com/channels/924522194736934912/927145048074756157";

    static Texture bannerImage;
    Vector2 ScrollPos = Vector2.zero;

    int toolbarInt = 0;
    string[] toolbarStrings = { "AboutSDK", "Changelog", "Important" };

    [MenuItem("DevloliSDK/AboutSDK", false, 500)]
    static void Initialize()
    {
        AboutSDK window = (AboutSDK)EditorWindow.GetWindowWithRect(typeof(AboutSDK), new Rect(0, 0, 525, 750));
    }

    public void OnEnable()
    {
        titleContent = new GUIContent("AboutSDK");
    }
    public void OnGUI()
    {
        if (bannerImage == null)
            bannerImage = AssetDatabase.LoadAssetAtPath<Texture>("Assets/VRCSDK/DevloliSDK/Resources/DevloliSDKBanner525.png");
        GUILayout.Box(bannerImage);
        GUI.backgroundColor = Color.grey;
        toolbarInt = GUILayout.Toolbar(toolbarInt, toolbarStrings);
        switch (toolbarInt)
        {
            case 0:
                ScrollPos = GUILayout.BeginScrollView(ScrollPos);
                GUILayout.Label(
    @"
 ===========================[ AboutSDK ]===========================

    ° SDK Details
        - Asset Import from Urls
        - SDK Small file size
        - Eazy Thumbnail Setup
        - VRCA & VRCW Download
        - Show Device Specific

   
============================[ Contact ]============================

    ° Discord : ! Devloli#8883
    ° VRChat  : -BΛD ΣПD-

    Thank you for using DevloliSDK.

================================================================
"
                );
                GUILayout.EndScrollView();

                GUILayout.FlexibleSpace();

                GUILayout.BeginHorizontal();

                GUI.backgroundColor = Color.grey;
                if (GUILayout.Button("\n★DevloliSDK Server★\n"))
                {
                    Application.OpenURL(devlolisdkdiscord);

                }
                if (GUILayout.Button("\n★DevloliSDK Website★\n"))
                {
                    Application.OpenURL(devlolisdkwebsite);

                }

                GUILayout.EndHorizontal();
                break;

            case 1:
                ScrollPos = GUILayout.BeginScrollView(ScrollPos);
                GUILayout.Label(
    @"
 ===========================[ Changelog ]=========================

    [+] added
    [-] remove
    [>] fix
    [/] update 

==============================================================

    [v1.50]
        + DevloliSDK.dll
        + VRCA & VRCW Download

        - HWID Spoofer
        - Removed size limit
        - Removed API Stuff
        - Proton Download
        - Reload SDK

        > Website link in Upload Screen

==============================================================

    [V1.41]
        + Assets Website in Import Panel

        > UnityChanToon (Really)
        > Show Control Panel
        > Avatar 3.0 Emulator link
    
==============================================================
    [V1.40]

        + MissingRemover under DevloliSDK/Tools/
        + ReflexShader 2.2.0
        + Developer Status
        + New Important
        + MatPack
        + Avatar 3.0 Emulator
        + Assets Website in Import Panel
        + Download VRCA & VRCW
        + Device Specifications

        / AvatarTools 2.1.2 to 2.1.3

        > VRCCam
        > Fix some words
        > Stuff API
         DevloliSDK User Status
        > AboutSDK Panel
        > Website link
        > UnityChanToon
        > DiscordRPC

==============================================================
    [V1.32]

        + LukaShader 12
        + AnimationKeyPanel

        - Sanctuary.moe in import panel 
        - BetterKeyFraming

        > Parameters 99999 to 21474791
        > HWID Spoof

        / Poiyomi 7.3.029 to 8.0.068
        / lilToon 1.2.3 to 1.2.9 
        / Sanao 1.5.1 to 1.5.3 
        / DynamicBone 1.3.1 to 1.3.2

==============================================================
    [V1.30]

        + Proton download
        + VRCQuestTools-v1.1.2
        + 4 Assets website in import panel 
        + Changelog in AboutSDK
        + DevloliSDK website button in import panel & AboutSDK
        + Preview image in upload panel
        + Hyperlink in upload panel 
        + Switch bar in AboutSDK

        > Discord invite link
        > All new image
        > Discord rpc
        > Upload panel
        > AboutSDK 

==============================================================
    [V1.24.5]
   
        - Changelog in About SDK

        > Fix some bug
        > Edit some words

==============================================================
    [V1.24]

        + DopeTexture 1.0.2
        + MochiesScreenFX
        + UnityChanToon 2.0.8
        + SanaoShader 1.5.1
        + ComboGestureExpressions 1.5.2
        + WorldAudio Prefab
        + LoadBundle

        - VRCExpressionTools 4.2.0

        > Move QHierarchy from VRCSDK to Import Panel
        > Edit some words

        / DopeShader 2.2.5 to 2.2.6
        / DopeToon 1.31 to 1.4.0
        / DynamicBone 1.3.0 to 1.3.1
   
==============================================================
    [V1.21]

        + HWID Spoof
        + Parameter MaxLimit 99999
        + Removed size limit
        + Removed API Stuff
        + Asset Import from Discord
        + Small file size (13.4MB)
        + WorldConstaints
        + PumkinsAvatarToon 0.9.6b

        / Update PoiyomiPro 7.3.013 to PoiyomiPro 7.3.029

==============================================================
"
                );
                GUILayout.EndScrollView();

                GUILayout.Space(4);

                GUI.backgroundColor = Color.grey;
                if (GUILayout.Button("\n★Latest Version★\n"))
                {
                    Application.OpenURL(devloliupdate);
                }

                GUILayout.FlexibleSpace();

                GUILayout.BeginHorizontal();

                GUILayout.FlexibleSpace();

                GUILayout.EndHorizontal();
                break;

            case 2:
                ScrollPos = GUILayout.BeginScrollView(ScrollPos);
                GUILayout.Label(
    @"
  ===========================[ Important ]==========================

    * Unusual Client Behivor
    If you get a message unusual client behivor In-game VRChat.

    How to fix !!

    1)  Start VRChat.
    2)  logout.
    3)  login again.

==============================================================
    
    * Account Permanently Unity  Banned
    if you got banned by unity.
    
    How to fix !!
    
    1) Press and hold Windows + R to open run.
    
    2) Paste text. 
    
    '' %temp%\DefaultCompany ''
    
    3) Delete DefaultCompany folder.

==============================================================

"
                );
                GUILayout.EndScrollView();

                GUILayout.Space(4);

                GUI.backgroundColor = Color.grey;
                if (GUILayout.Button("\n★Learn More\n"))
                {
                    Application.OpenURL(learn_more);
                }

                GUILayout.FlexibleSpace();

                GUILayout.BeginHorizontal();

                GUILayout.FlexibleSpace();

                GUILayout.EndHorizontal();
                break;

        }
    }
}