using UnityEngine;
using UnityEngine.Events;

public class ItemCollector : MonoBehaviour
{
    public const string CollectibleItemTag = "CollectibleItem";
    public UnityEvent onItemCollected;
    [SerializeField]
    private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag(CollectibleItemTag))
        {
            collectSoundEffect.Play();

            // Trigger collected animation - handles collision removal and destruction
            Animator collectedItemAnimator = collider.gameObject.GetComponent<Animator>();
            collectedItemAnimator.SetTrigger("collected");

            // Increment collected item tracker and fire event
            onItemCollected.Invoke();
        }
    }
}
