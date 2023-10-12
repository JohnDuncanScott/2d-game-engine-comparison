using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerDamageController : MonoBehaviour
{
    public UnityEvent onEnemyKill;
    public UnityEvent onPlayerDeath;
    public UnityEvent onPlayerRespawn;
    private Rigidbody2D playerRigidBody;
    private Animator playerAnimator;
    [SerializeField]
    private AudioSource playerDeathSoundEffect;
    private bool disablePlayerDeath;
    private Vector3 lastCheckpointPosition;

    public void OnCheckpointEntered(GameObject checkpoint)
    {
        lastCheckpointPosition = checkpoint.transform.position;
    }

    public void OnLevelCompleted()
    {
        disablePlayerDeath = true;
    }

    private void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (disablePlayerDeath)
        {
            return;
        }

        if (collision.gameObject.CompareTag("Trap"))
        {
            KillPlayer();
            return;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (disablePlayerDeath)
        {
            return;
        }

        // Enemies need to be triggers because otherwise player can land on an enemy and
        // therefore not be falling which then breaks the "fall on enemy head to kill" logic
        if (collider.gameObject.CompareTag("Enemy"))
        {
            bool isPlayerFalling = playerRigidBody.velocity.y < -0.1f;

            if (isPlayerFalling)
            {
                KillEnemy(collider.gameObject);
                return;
            }

            KillPlayer();
        }
    }

    // This isn't very flexible but works for the demo since every enemy is a WaypointFollower
    private void KillEnemy(GameObject enemy)
    {
        // Allow things like bouncing off enemy head
        onEnemyKill.Invoke();

        // Trigger death animation - handles collision removal and destruction
        Animator enemyAnimator = enemy.GetComponent<Animator>();
        enemyAnimator.SetTrigger("death");
    }

    private void KillPlayer()
    {
        // Allow things like stopping player movement
        onPlayerDeath.Invoke();
        playerDeathSoundEffect.Play();
        playerAnimator.SetTrigger("death");
    }

    // Call this from the animation because it's the easiest way of handling the requirement to have a delay
    private void Restart()
    {
        if (lastCheckpointPosition == Vector3.zero)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            // Player Y is off by 1 for some reason, so need to re-calculate so player respawns at base of checkpoint
            gameObject.transform.position = new Vector2(lastCheckpointPosition.x, lastCheckpointPosition.y - 1);
            onPlayerRespawn.Invoke();
        }
    }
}
