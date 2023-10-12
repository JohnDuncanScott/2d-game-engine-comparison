using UnityEngine;

// Makes sure player moves with platform when they touch it. Simplest way is to set the parent
public class StickyPlatform : MonoBehaviour
{
    // Setting one of the box colliders to be a trigger allows us to differentiate between them.
    // This is the collider that's on the top surface
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (IsPlayer(collider))
        {
            collider.gameObject.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (IsPlayer(collider))
        {
            collider.gameObject.transform.SetParent(null);
        }
    }

    private bool IsPlayer(Collider2D collider)
    {
        return collider.gameObject.name == "Player";
    }
}
