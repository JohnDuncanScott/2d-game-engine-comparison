using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Can't use GetComponent because that only works inside a class, so have to setup in Editor
    [SerializeField]
    private Transform player;
    private void Update()
    {
        // Don't overwrite camera Z value because it hovers above the scene
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
