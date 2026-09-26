using UnityEngine;

[CreateAssetMenu(fileName = "SO_Stats", menuName = "Scriptable Objects/SO_Stats")]
public class SO_Stats : ScriptableObject
{
    [SerializeField] private int maxHealth;
    [SerializeField] private float movementSpeed;
    [SerializeField] private int strength;
    [SerializeField] private float attackSpeed;
    
    public int MaxHealth
    {
        get { return maxHealth; }
    }
    public float MovementSpeed
    {
        get { return movementSpeed; }
    }
    public int Strength
    {
        get { return strength; }
    }
    public float AttackSpeed
    {
        get { return attackSpeed; }
    }
}
