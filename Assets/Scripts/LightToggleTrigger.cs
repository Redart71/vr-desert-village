using UnityEngine;

public class LightToggleTrigger : MonoBehaviour
{
    public Light lightToControl;
    public bool turnOn = true;
    private void Start()
    {
        if (lightToControl != null)
            lightToControl.enabled = !turnOn;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Controller"))
        {
            if (lightToControl != null)
            {
                lightToControl.enabled = turnOn;
                Debug.Log("Lumière modifiée : " + lightToControl.name);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Controller"))
        {
            if (lightToControl != null)
            {
                lightToControl.enabled = !turnOn;
                Debug.Log("Sortie de la zone - lumière OFF : " + lightToControl.name);
            }
        }
    }
}
