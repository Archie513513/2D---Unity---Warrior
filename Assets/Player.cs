using UnityEngine;

public class Player : Entity
{
    [SerializeField] private float JumpForce = 4;
    [SerializeField] protected float MoveSpeed = 3.5f;
    private bool isGrounded = true;
    private float xInput;


    protected override void Update()
    {
        base.Update();
        HandleInput();
    }

    private void HandleInput()
    {
        xInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
            TryToJump();

        if (Input.GetKeyDown(KeyCode.Mouse0))
            HandleAttack();

    }
    protected override void HandleMovement()
    {
        if (canMove == true)
            rb.linearVelocity = new Vector2(xInput * MoveSpeed, rb.linearVelocity.y);
        else
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
    }

    private void TryToJump()
    {
        if (isGrounded && canJump)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
    }

    public override void EnableMovement(bool enable)
    {
        base.EnableMovement(enable);
        canJump = enable;
    }
}
