using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private PlayerSetup playerSetup;
    [SerializeField] private PlayerMovementState moveState;

    public void TakeDamage(int damage)
    {
        playerSetup.CurrentHealth -= damage;
        if (playerSetup.CurrentHealth > 0)
        {
            moveState.SetPlayerMoveState(PlayerMovementState.PlayerMoveState.Damage);
        }
        else if (playerSetup.CurrentHealth <= 0)
        {
            moveState.SetPlayerMoveState(PlayerMovementState.PlayerMoveState.Die);
            playerSetup.IsDead = true;
            Debug.Log("Player is dead");
        }
        Debug.Log("Hit");
    }
}
