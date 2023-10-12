using UnityEngine;
using UnityEngine.SceneManagement;

// Can be refactored to reduce duplication with EndMenu
public class StartMenu : MonoBehaviour
{
    private SimplePlatformerInput input;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
        StartGame();
    }
}
