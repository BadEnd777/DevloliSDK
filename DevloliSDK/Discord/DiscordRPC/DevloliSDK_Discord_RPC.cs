using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DevloliSDK
{
    [InitializeOnLoad]
    public class DevloliSDK_DiscordRPC
    {
        private static readonly DiscordRpc.RichPresence presence = new DiscordRpc.RichPresence();

        private static TimeSpan time = (DateTime.UtcNow - new DateTime(1970, 1, 1));
        private static long timestamp = (long)time.TotalSeconds;

        private static string devlolisdkversion = "1.51";
        private static string discord_app_id = "934331344262135878";

        private static RpcState rpcState = RpcState.EDITMODE;
        private static string GameName = Application.productName;
        private static string SceneName = SceneManager.GetActiveScene().name;

        static DevloliSDK_DiscordRPC()
        {
            if (EditorPrefs.GetBool("DevloliSDK", true))
            {
                devLog("Starting discord rpc");
                DiscordRpc.EventHandlers eventHandlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize(discord_app_id, ref eventHandlers, false, string.Empty);
                updateDRPC();
            }
        }

        public static void updateDRPC()
        {
            devLog("Updating everything");
            SceneName = SceneManager.GetActiveScene().name;
            presence.details = string.Format("Project: {0} Scene: {1}", GameName, SceneName);
            presence.state = "State: " + rpcState.StateName();
            presence.startTimestamp = timestamp;
            presence.largeImageKey = "dllbg";
            presence.largeImageText = "DevloliSDK " + devlolisdkversion;
            presence.smallImageKey = "unity-w";
            presence.smallImageText = "Unity " + Application.unityVersion;

            DiscordRpc.UpdatePresence(presence);
        }

        public static void updateState(RpcState state)
        {
            devLog("Updating state to '" + state.StateName() + "'");
            rpcState = state;
            presence.state = "State: " + state.StateName();
            DiscordRpc.UpdatePresence(presence);
        }

        public static void sceneChanged(Scene newScene)
        {
            devLog("Updating scene name");
            SceneName = newScene.name;
            presence.details = string.Format("Project: {0} Scene: {1}", GameName, SceneName);
            DiscordRpc.UpdatePresence(presence);
        }

        public static void ResetTime()
        {
            devLog("Reseting timer");
            time = (DateTime.UtcNow - new DateTime(1970, 1, 1));
            timestamp = (long)time.TotalSeconds;
            presence.startTimestamp = timestamp;

            DiscordRpc.UpdatePresence(presence);
        }

        private static void devLog(string message)
        {
            Debug.Log("[DevloliSDK] DiscordRPC: " + message);
        }
    }
}