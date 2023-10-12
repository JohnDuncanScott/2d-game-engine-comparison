using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    private SpriteRenderer sprite;
    [SerializeField]
    private GameObject[] waypoints;
    [SerializeField]
    private float speed = 2f;
    [SerializeField]
    private bool flipHorizontallyAtWaypoint;
    [SerializeField]
    private AudioSource destroySoundEffect;
    private int currentWaypointIndex = 0;
    private bool isMovementEnabled = true;


    // Ensures that the game object AND all its waypoints get cleaned up and finally the parent game object
    public void Destroy()
    {
        GameObject parentGameObject = gameObject.transform.parent.gameObject;
        Destroy(gameObject);

        foreach (GameObject waypoint in waypoints)
        {
            Destroy(waypoint);
        }

        Destroy(parentGameObject);
    }

    public void DisableMovement()
    {
        isMovementEnabled = false;
    }

    public void PlayDestroySoundEffect()
    {
        destroySoundEffect.Play();
    }

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Move something frame by frame rather than by velocity because it's simpler
    private void Update()
    {
        GameObject currentWaypoint = waypoints[currentWaypointIndex];

        // Due to imprecision, don't use == 0
        if (Vector2.Distance(currentWaypoint.transform.position, transform.position) < 0.1f)
        {
            currentWaypointIndex++;

            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }

            // Quick fix to get enemies flipping at waypoints. This needs to be more sophisticated if more than 2 waypoints are used.
            // Could probably be done in a separate script like the Rotate script
            if (flipHorizontallyAtWaypoint)
            {
                sprite.flipX = !sprite.flipX;
            }
        }

        if (isMovementEnabled)
        {
            // Time.deltaTime allows you to make calculation framerate independent
            transform.position = Vector2.MoveTowards(transform.position, currentWaypoint.transform.position, Time.deltaTime * speed);
        }
    }
}
