using System;
using UnityEngine;

public class PlayerMovementState : MonoBehaviour
{
    public enum PlayerMoveState
    {
        Idle,
        Run,
        Attack,
        Damage,
        Die
    }
    
    public PlayerMoveState CurrentPlayerMoveState { get; private set; }
    
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;

    private const string IdleAnim = "Idle";
    private const string RunAnim = "Run";
    private const string AttackAnim = "Attack";
    private const string DamageAnim = "Damage";
    private const string DieAnim = "Die";
    public static Action<PlayerMoveState> OnMoveStateChange;
    private float xPosLastFrame;
    private float yPosLastFrame;
    
    public void SetPlayerMoveState(PlayerMoveState playerMoveState)
    {
        if (playerMoveState == CurrentPlayerMoveState) return;

        switch (playerMoveState)
        {
            case PlayerMoveState.Idle:
                HandleIdle();
                break;
            case PlayerMoveState.Run:
                HandleRun();
                break;
            case PlayerMoveState.Attack:
                HandleAttack();
                break;
            case PlayerMoveState.Damage:
                HandleDamage();
                break;
            case PlayerMoveState.Die:
                HandleDie();
                break;
            default:
                Debug.LogError($"{playerMoveState} is an invalid movement state!");
                break;
        }
        
        OnMoveStateChange?.Invoke(playerMoveState);
        CurrentPlayerMoveState = playerMoveState;
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
        animator.SetTrigger("Attack");
    }

    private void HandleDamage()
    {
        animator.SetTrigger("Damage");
    }

    private void HandleDie()
    {
        animator.Play(DieAnim);
    }
}
