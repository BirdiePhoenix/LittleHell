using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public SO_Stats enemyStats;
    [SerializeField] MovementState movementState;

    public Rigidbody2D enemyRb;
    private GameObject player;
    private float distance;
    [SerializeField] private float stoppingDistance;
    private Vector2 moveDirection;
    
    private float moveSpeed;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        
        moveSpeed = enemyStats.MovementSpeed; 
    }

    void Update()
    {
        distance = Vector2.Distance(player.transform.position, transform.position);
        Vector2 lookDirection = (player.transform.position - transform.position).normalized;
        
        movementState.SetMoveState(MovementState.MoveState.Run);
        enemyRb.MovePosition(enemyRb.position + lookDirection * moveSpeed * Time.fixedDeltaTime);
    }
}
