using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private List<EnemyHealth> enemies;
    [SerializeField] PlayerSetup playerSetup;
    [SerializeField] PlayerMovementState moveState;
    
    private void Start()
    {
        enemies = new List<EnemyHealth>();
    }

    public void AttackEnemies(EnemyHealth enemyHealth)
    {
        enemyHealth.TakeDamage(playerSetup.CurrentStrength);
    }
    public void TriggerAttack()
    {
        StartCoroutine(Attack());
    }

    private IEnumerator Attack()
    {
        moveState.SetPlayerMoveState(PlayerMovementState.PlayerMoveState.Attack);
        yield return new WaitForSeconds(playerSetup.CurrentAttackSpeed);
    }
    public void AddEnemyToList(EnemyHealth enemy)
    {
        enemies.Add(enemy);
    }

    public void RemoveEnemyFromList(EnemyHealth enemy)
    {
        enemies.Remove(enemy);
    }
}
