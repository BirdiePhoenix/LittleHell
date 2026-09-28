using System;
using UnityEngine;

public class MovementState : MonoBehaviour
{
    public enum MoveState
    {
        Idle,
        Run,
        Attack,
        Damage,
        Die
    }
    
    public MoveState CurrentMoveState { get; private set; }
    
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;

    private const string IdleAnim = "Idle";
    private const string RunAnim = "Run";
    private const string AttackAnim = "Attack";
    private const string DamageAnim = "Damage";
    private const string DieAnim = "Die";
    public static Action<MoveState> OnMoveStateChange;
    private float xPosLastFrame;
    private float yPosLastFrame;
    
    public void SetMoveState(MoveState moveState)
    {
        if (moveState == CurrentMoveState) return;

        switch (moveState)
        {
            case MoveState.Idle:
                HandleIdle();
                break;
            case MoveState.Run:
                HandleRun();
                break;
            case MoveState.Attack:
                HandleAttack();
                break;
            case MoveState.Damage:
                HandleDamage();
                break;
            case MoveState.Die:
                HandleDie();
                break;
            default:
                Debug.LogError($"{moveState} is an invalid movement state!");
                break;
        }
        
        OnMoveStateChange?.Invoke(moveState);
        CurrentMoveState = moveState;
    }

    private void HandleIdle()
    {
        animator.Play(IdleAnim);
    }

    private void HandleRun()
    {
        animator.Play(RunAnim);
    }

    private void HandleAttack()
    {
        animator.Play(AttackAnim);
    }

    private void HandleDamage()
    {
        animator.Play(DamageAnim);
    }

    private void HandleDie()
    {
        animator.Play(DieAnim);
    }
}
