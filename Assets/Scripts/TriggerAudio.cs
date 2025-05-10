using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Controller"))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}
