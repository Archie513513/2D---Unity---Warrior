using System;
using UnityEngine;

public class ObjectToProtect : Entity
{
    [Header("Extra details")]
    [SerializeField] private Transform player;



    protected override void Update()
    {
        HandleFlip();
    }

    //protected override void HandleFlip()
    //{
    //    if (player.transform.position.x > transform.position.x  && facingRight == false)
    //        FlipCharacter();
    //    else if (player.transform.position.x < transform.position.x && facingRight == true)
    //        FlipCharacter();
    //}

    protected override void Die()
    {
        base.Die();
        UI.instance.EnablegameOverUI();
    }
}
