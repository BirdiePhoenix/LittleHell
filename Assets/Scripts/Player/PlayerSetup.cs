using System;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    [SerializeField] private SO_Stats playerStats;

    private int currentHealth;
    private float movementSpeed;
    private int strength;
    private float attackSpeed;

    private void Start()
    {
        currentHealth = playerStats.MaxHealth;
        movementSpeed = playerStats.MovementSpeed;
        strength = playerStats.Strength;
        attackSpeed = playerStats.AttackSpeed;
    }
    
    public int CurrentHealth
    {
        get {return currentHealth;}
        set {currentHealth = value;}
    }
    public float MovementSpeed
    {
        get {return movementSpeed;}
        set {movementSpeed = value;}
    }
    public int Strength
    {
        get {return strength;}
        set {strength = value;}
    }
    public float AttackSpeed
    {
        get {return attackSpeed;}
        set {attackSpeed = value;}
    }
}
