using UnityEngine;
using System.Threading.Tasks;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private EnemySetup enemySetup;
    [SerializeField] private EnemyMovementState moveState;
    [SerializeField] private Animator animator;

    private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }
    

    public void TriggerAttack()
    {
        StartCoroutine(Attack());
    }

    private void DamagePlayer()
    {
        playerHealth.TakeDamage(enemySetup.CurrentStrength);
    }

    private IEnumerator Attack()
    {
        moveState.SetMoveState(EnemyMovementState.EnemyMoveState.Attack);
        yield return new WaitForSeconds(enemySetup.CurrentAttackSpeed);
   
        if (enemySetup.IsInRange)
        {
            StartCoroutine(Attack());
        }
    }
}
