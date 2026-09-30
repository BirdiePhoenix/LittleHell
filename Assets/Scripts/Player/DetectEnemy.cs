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
            playerAttack.AddEnemyToList(other.gameObject);
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerAttack.RemoveEnemyFromList(other.gameObject);
            //enemySetup.IsInRange = false;
        }
    }
}
