using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    private AudioSource enteredSoundEffect;
    private BoxCollider2D coll;
    private Animator animator;
    private CheckpointParent.CheckpointEnteredEvent onCheckpointEntered;

    // Start is called before the first frame update
    private void Start()
    {
        coll = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        onCheckpointEntered = GetComponentInParent<CheckpointParent>().onCheckpointEntered;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // If player enters, store their location so player can respawn here
        if (collider.gameObject.name == "Player")
        {
            // Stops checkpoint triggering again
            coll.enabled = false;
            enteredSoundEffect.Play();
            animator.SetTrigger("enter");
            onCheckpointEntered.Invoke(gameObject);
        }
    }
}
