using System;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    [SerializeField] private PlayerAttack playerAttack;
    [SerializeField] private PlayerSetup playerSetup;
    

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            playerAttack.TriggerAttack();
            // EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
            // playerAttack.AttackEnemies(enemyHealth);
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
            // playerAttack.RemoveEnemyFromList(enemyHealth);
        }
    }
}
