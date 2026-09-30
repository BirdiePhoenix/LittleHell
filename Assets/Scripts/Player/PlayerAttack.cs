using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private List<GameObject> enemies;
    
    private void Start()
    {
        enemies = new List<GameObject>();
    }

    public void AttackEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            
        }
    }

    public void AddEnemyToList(GameObject enemy)
    {
        enemies.Add(enemy);
    }

    public void RemoveEnemyFromList(GameObject enemy)
    {
        enemies.Remove(enemy);
    }
}
