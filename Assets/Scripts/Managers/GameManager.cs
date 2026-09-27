using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;

    [SerializeField] private Vector2 playerSpawnPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        SpawnPlayer();
    }
    
    private void SpawnPlayer()
    {
        Instantiate(playerPrefab, playerSpawnPos, quaternion.identity);
    }

    public void SceneTransition()
    {
        
    }
}
