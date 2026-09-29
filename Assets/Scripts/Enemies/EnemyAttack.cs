using UnityEngine;
using System.Threading.Tasks;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private EnemySetup enemySetup;
    [SerializeField] private MovementState moveState;

    private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // private void OnCollisionEnter2D(Collision2D other)
    // {
    //     Debug.Log("Hit");
    //     if (other.gameObject.tag == "Player")
    //     {
    //         Debug.Log("Player");
    //         playerHealth.TakeDamage(enemySetup.CurrentStrength);
    //         StartCoroutine(Attack());
    //     }
    // }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player");
            enemySetup.IsInRange = true;
            playerHealth.TakeDamage(enemySetup.CurrentStrength);
            moveState.SetMoveState(MovementState.MoveState.Attack);
            StartCoroutine(Attack());
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemySetup.IsInRange = false;
        }
    }

    private IEnumerator Attack()
    {
        yield return new WaitForSeconds(enemySetup.CurrentAttackSpeed);
        moveState.SetMoveState(MovementState.MoveState.Attack);
        playerHealth.TakeDamage(enemySetup.CurrentStrength);
    }
}
