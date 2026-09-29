using UnityEngine;

public class PlayerHealth : MonoBehaviour, IObserver
{
    [SerializeField] private PlayerSetup playerSetup;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void TakeDamage(int damage)
    {
        playerSetup.CurrentHealth -= damage;
    }

    public void OnNotify()
    {
        
    }
}
