using UnityEngine;
using TMPro;

public class KeyboardInput : MonoBehaviour
{
    public TMP_InputField inputField;

    public void AddCharacter(string character)
    {
        inputField.text += character;
    }

    public void Backspace()
    {
        if (!string.IsNullOrEmpty(inputField.text))
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
    }

    public void Submit()
    {
        Debug.Log("Texte soumis : " + inputField.text);
    }
}
