using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    [SerializeField] private PlayerAttack playerAttack;
    [SerializeField] private PlayerSetup playerSetup;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy");
            //enemySetup.IsInRange = true;
            //enemyAttack.TriggerAttack();
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //enemySetup.IsInRange = false;
        }
    }
}
