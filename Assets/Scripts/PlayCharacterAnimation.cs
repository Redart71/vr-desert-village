using UnityEngine;

public class PlayCharacterAnimation : MonoBehaviour
{
    public Animator animator;

    public void PlayAnimation(string animationName)
    {
        if (animator != null)
        {
            animator.Play(animationName);
        }
    }
}
