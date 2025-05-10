using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;


public class TeleportOnTrigger : MonoBehaviour
{
    public Transform teleportTarget;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Controller"))
        {
            GameObject xrOrigin = FindAnyObjectByType<XROrigin>()?.gameObject;
            if (xrOrigin != null)
            {
                xrOrigin.transform.position = teleportTarget.position;
                Debug.Log("Téléporté !");
            }
        }
    }
}
