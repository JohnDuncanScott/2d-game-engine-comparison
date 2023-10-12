using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Editable fields
    [SerializeField]
    private LayerMask jumpableGround;
    [SerializeField]
    private float moveSpeed = 7f;
    [SerializeField]
    private float jumpForce = 14f;
    [SerializeField]
    private float minimumJumpForce = 7f;
    [SerializeField]
    private AudioSource jumpSoundEffect;
    [SerializeField]
    private ParticleSystem dustPS;

    // Components
    // There's a deprecated "rigidBody" on MonoBehaviour so have to use different name
    private Rigidbody2D rb;
    // There's a deprecated "collider" on MonoBehaviour so have to use different name
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator animator;
    private SimplePlatformerInput input;

    // Fields
    private float directionX;
    private bool isPlayerMovementEnabled = true;
    private MovementState currentMovementState = MovementState.IDLE;
    private MovementState previousMovementState = MovementState.IDLE;

    // Integer values from this are used in the Animator movementState parameter
    private enum MovementState
    {
        IDLE,
        RUNNING,
        JUMPING,
        FALLING
    }

    public void OnEnemyKill()
    {
        Jump();
    }

    public void OnLevelCompleted()
    {
        isPlayerMovementEnabled = false;
        ResetVelocityX();
    }

    public void OnPlayerDeath()
    {
        isPlayerMovementEnabled = false;
        ResetVelocityX();
        // Freeze player so animation happens correctly, even if in mid-air
        rb.bodyType = RigidbodyType2D.Static;
    }

    // This could be refactored to make it easier to understand
    public void OnPlayerRespawn()
    {
        // Rebind essentially resets the animator, so clears death trigger, etc.
        animator.Rebind();

        // Show the player (player was hidden using animation)
        sprite.enabled = true;

        // Unfreeze player
        rb.bodyType = RigidbodyType2D.Dynamic;
        isPlayerMovementEnabled = true;
    }

    private void Awake()
    {
        input = new SimplePlatformerInput();
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    #region Input setup

    private void RefreshDirectionX()
    {
        // Old input system - replaced with SimplePlatformerInput
        // Will be between -1 and +1. Something like a joystick can be left but not all the way left, so it's a range.
        // GetAxis vs. GetAxisRaw - GetAxis decreases gradually once user lets go of key. GetAxisRaw returns to 0 immediately. By using GetAxisRaw it
        // removes some of the floatiness when moving left and right
        //directionX = Input.GetAxisRaw("Horizontal");

        directionX = input.Player.Movement.ReadValue<Vector2>().x;
    }

    // Used to trigger a jump on press but not when held
    private bool IsJumpButtonDown()
    {
        // Old input system - replaced with SimplePlatformerInput
        //return Input.GetButtonDown("Jump");

        return input.Player.Jump.WasPressedThisFrame();
    }

    // Used to indicate an aborted jump
    private bool IsJumpButtonReleased()
    {
        // Old input system - replaced with SimplePlatformerInput
        //return !Input.GetButton("Jump");

        return !input.Player.Jump.IsPressed();
    }

    #endregion

    // Update is called once per frame
    private void Update()
    {
        if (isPlayerMovementEnabled)
        {
            RefreshDirectionX();

            // Multiplying makes sure we move in correct direction
            rb.velocity = new Vector2(directionX * moveSpeed, rb.velocity.y);

            // Handle jumping

            // Check if user has pressed jump button
            if (IsJumpButtonDown() && IsGrounded())
            {
                Jump();
            }

            // Check if a user has released jump button early
            if (currentMovementState == MovementState.JUMPING && IsJumpButtonReleased())
            {
                JumpRelease();
            }

            // Handle landing

            // Dust effect when landing
            if (previousMovementState == MovementState.FALLING && currentMovementState != MovementState.FALLING)
            {
                CreateDustEffect();
            }
        }

        UpdateMovementAndAnimationState();
    }

    private void Jump()
    {
        jumpSoundEffect.Play();
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void JumpRelease()
    {
        // Having a minimum jump force means the deceleration is less abrupt
        if (rb.velocity.y > minimumJumpForce)
        {
            rb.velocity = new Vector2(rb.velocity.x, minimumJumpForce);
        }
    }

    private void UpdateMovementAndAnimationState()
    {
        bool isRunningLeft = directionX < 0f;
        bool isRunningRight = directionX > 0f;
        previousMovementState = currentMovementState;

        // Check left / right first since it has lower priority
        if (isRunningLeft)
        {
            sprite.flipX = true;
            currentMovementState = MovementState.RUNNING;
        }
        else if (isRunningRight)
        {
            sprite.flipX = false;
            currentMovementState = MovementState.RUNNING;
        }
        else
        {
            currentMovementState = MovementState.IDLE;
        }

        // Now check jumping / falling since it has higher priority and should overwrite left / right
        // There's some imprecision here, so don't use 0. Epsilon (float.Epsilon) is too small, so don't use that either.
        bool isJumping = rb.velocity.y > 0.1f;
        bool isFalling = rb.velocity.y < -0.1f;

        if (isJumping)
        {
            currentMovementState = MovementState.JUMPING;
        }
        else if (isFalling)
        {
            currentMovementState = MovementState.FALLING;
        }

        animator.SetInteger("movementState", (int)currentMovementState);
    }

    // Use box cast to check for ground. Can't just use collision with tile because touching the left, right or bottom
    // of a platform would also count as "grounded".
    private bool IsGrounded()
    {
        // 0.1f is to offset the box slightly below the actual collider so we get slightly advanced warning of grounding and it
        // feels better
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);
    }

    private void ResetVelocityX()
    {
        directionX = 0;
        rb.velocity = new Vector2(0, rb.velocity.y);
    }

    private void CreateDustEffect()
    {
        dustPS.Play();
    }
}
