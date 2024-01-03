using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

namespace DevloliSDK
{
    [InitializeOnLoadAttribute]
    public static class DevloliSDK_DiscordRpcRuntimeHelper
    {
        // register an event handler when the class is initialized
        static DevloliSDK_DiscordRpcRuntimeHelper()
        {
            EditorApplication.playModeStateChanged += LogPlayModeState;
            EditorSceneManager.activeSceneChanged += sceneChanged;
        }

        private static void sceneChanged(Scene old, Scene next)
        {
            DevloliSDK_DiscordRPC.sceneChanged(next);
        }

        private static void LogPlayModeState(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.EnteredEditMode)
            {
                DevloliSDK_DiscordRPC.updateState(RpcState.EDITMODE);
                DevloliSDK_DiscordRPC.ResetTime();
            }
            else if (state == PlayModeStateChange.EnteredPlayMode)
            {
                DevloliSDK_DiscordRPC.updateState(RpcState.PLAYMODE);
                DevloliSDK_DiscordRPC.ResetTime();
            }
        }
    }
}