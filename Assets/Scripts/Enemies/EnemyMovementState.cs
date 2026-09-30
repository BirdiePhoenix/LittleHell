using System;
using UnityEngine;

public class EnemyMovementState : MonoBehaviour
{
    public enum EnemyMoveState
    {
        Idle,
        Run,
        Attack,
        Damage,
        Die
    }
    
    public EnemyMoveState CurrentEnemyMoveState { get; private set; }
    
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;

    private const string IdleAnim = "Idle";
    private const string RunAnim = "Run";
    private const string AttackAnim = "Attack";
    private const string DamageAnim = "Damage";
    private const string DieAnim = "Die";
    public static Action<EnemyMoveState> OnMoveStateChange;
    private float xPosLastFrame;
    private float yPosLastFrame;
    
    public void SetMoveState(EnemyMoveState enemyMoveState)
    {
        if (enemyMoveState == CurrentEnemyMoveState) return;

        switch (enemyMoveState)
        {
            case EnemyMoveState.Idle:
                HandleIdle();
                break;
            case EnemyMoveState.Run:
                HandleRun();
                break;
            case EnemyMoveState.Attack:
                HandleAttack();
                break;
            case EnemyMoveState.Damage:
                HandleDamage();
                break;
            case EnemyMoveState.Die:
                HandleDie();
                break;
            default:
                Debug.LogError($"{enemyMoveState} is an invalid movement state!");
                break;
        }
        
        OnMoveStateChange?.Invoke(enemyMoveState);
        CurrentEnemyMoveState = enemyMoveState;
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
