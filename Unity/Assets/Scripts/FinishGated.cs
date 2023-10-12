using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class FinishGated : MonoBehaviour
{
    public UnityEvent onLevelCompleted;
    [SerializeField]
    private TextMeshPro collectedItemsText;
    // This is for the C# script version of the fader
    // [SerializeField]
    // private Fader fader;
    private AudioSource finishSound;
    private bool isLevelCompleted;
    private int totalItems;
    private int collectedItemsCount;

    public void OnItemCollected()
    {
        collectedItemsCount++;
        UpdateCollectedItemsText(collectedItemsCount);
    }

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
        totalItems = GameObject.FindGameObjectsWithTag(ItemCollector.CollectibleItemTag).Length;
        UpdateCollectedItemsText(0);
        Fade();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isLevelCompleted ||
            !AreAllItemsCollected() ||
            collision.gameObject.name != "Player")
        {
            return;
        }

        onLevelCompleted.Invoke();
        isLevelCompleted = true;
        finishSound.Play();
        // Delay calling complete level so transition isn't so abrupt and give time for sound to play
        Invoke("CompleteLevel", 2f);
    }

    private void CompleteLevel()
    {
        // `buildIndex` can be found to right of scenes in `File` -> `Build Settings...`
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void UpdateCollectedItemsText(int collectedItemsCount)
    {
        // Switch color to make it clear when all items have been collected.
        // Will also need some visual indicator for colorblind people
        Color textColor = Color.red;

        if (AreAllItemsCollected())
        {
            textColor = Color.green;
            Unfade();
        }

        collectedItemsText.color = textColor;
        collectedItemsText.text = $"Collected: {collectedItemsCount} / {totalItems}";
    }

    private bool AreAllItemsCollected()
    {
        return collectedItemsCount == totalItems;
    }

    private void Fade()
    {
        // Use visual script to do this instead for demo purposes
        //fader.Fade();
        CustomEvent.Trigger(this.gameObject, "ChangeSpriteAlpha", 0.25f);
    }

    private void Unfade()
    {
        // Use visual script to do this instead for demo purposes
        //fader.Unfade();
        CustomEvent.Trigger(this.gameObject, "ChangeSpriteAlpha", 1.0f);
    }
}
