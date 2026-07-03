using UnityEngine;

public class Enemy : Entity
{
    [SerializeField] private bool playerDetected;
    [SerializeField] private float MoveSpeed = 3.5f;


    protected override void Update()
    {
        base.Update();
        HandleAttack();
    }

    protected override void HandleAttack()
    {
        if (playerDetected)
            anim.SetTrigger("attack");
    }


    protected override void HandleMovement()
    {
        if (canMove == true)
            rb.linearVelocity = new Vector2(facingDir * MoveSpeed, rb.linearVelocity.y);
        else
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);

    }

    protected override void HandleCollision()
    {
        base.HandleCollision();
        playerDetected = Physics2D.OverlapCircle(attackPoint.position, attackRadius, whatIsTarget);
    }

    protected override void Die()
    {
        base.Die();
        UI.instance.AddKillCount();
    }
}
