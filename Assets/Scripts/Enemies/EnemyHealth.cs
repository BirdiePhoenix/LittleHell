using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private EnemySetup enemySetup;
    [SerializeField] private EnemyMovementState moveState;

    public void TakeDamage(int damage)
    {
        enemySetup.CurrentHealth -= damage;
        if (enemySetup.CurrentHealth > 0)
        {
            moveState.SetMoveState(EnemyMovementState.EnemyMoveState.Damage);
        }
        else if (enemySetup.CurrentHealth <= 0)
        {
            moveState.SetMoveState(EnemyMovementState.EnemyMoveState.Die);
            enemySetup.IsDead = true;
            Debug.Log("Enemy is dead");
        }
        Debug.Log("Hit");
    }
}
