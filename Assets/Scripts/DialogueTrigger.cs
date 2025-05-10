using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueUI;

    private void Start()
    {
        if (dialogueUI != null)
        {
            dialogueUI.SetActive(true); 
            dialogueUI.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("MainCamera"))
        {
            dialogueUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("MainCamera"))
        {
            dialogueUI.SetActive(false);
        }
    }
}
