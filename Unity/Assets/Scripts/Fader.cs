using UnityEngine;

public class Fader : MonoBehaviour
{
    [SerializeField]
    private float fadedAlpha = 0.25f;
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void Fade()
    {
        ChangeAlpha(fadedAlpha);
    }

    public void Unfade()
    {
        // Really should store original alpha and reset to that, but this works for this demo
        ChangeAlpha(1f);
    }

    private void ChangeAlpha(float alpha)
    {
        Color currentColor = sprite.color;
        sprite.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
    }
}
