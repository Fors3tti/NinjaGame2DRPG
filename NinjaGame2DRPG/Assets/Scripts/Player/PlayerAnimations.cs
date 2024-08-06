using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetDeadAnimation()
    {
        animator.SetTrigger("Dead");
    }

    public void SetMoveBoolTransition(bool value)
    {
        animator.SetBool("Moving", value);
    }

    public void SetMoveAnimation(Vector2 dir)
    {
        animator.SetFloat("MoveX", dir.x);
        animator.SetFloat("MoveY", dir.y);
    }

    public void SetAttackAnimation(bool value)
    {
        animator.SetBool("Attacking", value);
    }

    public void ResetPlayer()
    {
        SetMoveAnimation(Vector2.down);
        animator.SetTrigger("Revive");
    }
}
