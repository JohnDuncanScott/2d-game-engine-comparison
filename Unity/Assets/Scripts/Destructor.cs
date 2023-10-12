using UnityEngine;

// Animator requires a script to destroy something
public class Destructor : MonoBehaviour
{
    private void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
