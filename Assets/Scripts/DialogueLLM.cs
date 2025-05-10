using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using System.Collections;


public class DialogueLLM : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text outputText;

    public void OnSendClicked()
    {
        string userMessage = inputField.text;
        StartCoroutine(SendToLLM(userMessage));
    }

    IEnumerator SendToLLM(string message)
    {
        string apiUrl = "https://api.mistral.ai/v1/chat/completions";

        string jsonBody = "{\"message\": \"" + message + "\"}";
        UnityWebRequest request = UnityWebRequest.PostWwwForm(apiUrl, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonBody);

        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            string responseText = request.downloadHandler.text;
            outputText.text = responseText;
        }
        else
        {
            outputText.text = "Erreur de connexion au LLM.";
        }
    }
}
