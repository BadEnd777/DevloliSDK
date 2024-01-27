using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;

public class BugReport : EditorWindow
{
    string webhookURL = "";
    string message = "";
    string username = "DevloliSDK";
    string avatar = "https://devloli-main.github.io/images/Dllbg.png";
    string send = "__**BugReport**__\n```";

    [MenuItem("DevloliSDK/Help/Bug Report")]
    static void Init()
    {
        EditorWindow.GetWindow(typeof(BugReport));
    }

    void OnGUI()
    {
        minSize = new Vector2(500, 500);
        maxSize = new Vector2(500, 500);
        GUILayout.Label("\nBug Report", EditorStyles.boldLabel);
        message = EditorGUILayout.TextField(message);
        EditorGUILayout.Space(10);
        if (message.Length > 0)
        {
            GUI.backgroundColor = Color.green;
        }
        else
        {
            GUI.backgroundColor = Color.red;
        }
        if (GUILayout.Button("Send Report"))
        {
            if (message.Length > 0)
            {
                SendReport();
                EditorUtility.DisplayDialog("DevloliSDK", "Thank you for report!", "OK");
                Close();
            }
            else
            {
                EditorUtility.DisplayDialog("Error", "Please input a message in the text field.", "OK");
            }
        }
    }

    void SendReport()
    {
        var form = new WWWForm();
        form.AddField("username", username);
        form.AddField("avatar_url", avatar);
        form.AddField("content", send + message + "```");

        var www = UnityWebRequest.Post(webhookURL, form);
        www.SendWebRequest();
    }

}
