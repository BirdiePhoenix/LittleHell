using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private PlayerSetup playerSetup;
    [SerializeField] private MovementState moveState;

    public void TakeDamage(int damage)
    {
        playerSetup.CurrentHealth -= damage;
        if (playerSetup.CurrentHealth > 0)
        {
            moveState.SetMoveState(MovementState.MoveState.Damage);
        }
        Debug.Log("Hit");
    }
}
