using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class FinishSimple : MonoBehaviour
{
    public UnityEvent onLevelCompleted;
    private AudioSource finishSound;
    private bool isLevelCompleted;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" &&
            !isLevelCompleted)
        {
            onLevelCompleted.Invoke();
            isLevelCompleted = true;
            finishSound.Play();
            // Delay calling complete level so transition isn't so abrupt and give time for sound to play
            Invoke("CompleteLevel", 2f);
        }
    }

    private void CompleteLevel()
    {
        // `buildIndex` can be found to right of scenes in `File` -> `Build Settings...`
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
