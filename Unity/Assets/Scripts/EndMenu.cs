using UnityEngine;

// Can be refactored to reduce duplication with StartMenu
public class EndMenu : MonoBehaviour
{
    private SimplePlatformerInput input;

    public void Quit()
    {
        Application.Quit();
    }

    private void Awake()
    {
        input = new SimplePlatformerInput();
    }

    private void OnEnable()
    {
        input.Enable();
        input.Player.Jump.performed += OnJumpPerformed;
    }

    private void OnDisable()
    {
        input.Disable();
        input.Player.Jump.performed -= OnJumpPerformed;
    }

    private void OnJumpPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Quit();
    }
}
