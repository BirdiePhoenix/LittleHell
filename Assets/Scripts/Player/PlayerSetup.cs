using System;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    [SerializeField] private SO_Stats playerStats;

    private int currentHealth;
    private float currentMovementSpeed;
    private int currentStrength;
    private float currentAttackSpeed;
    private float currentAttackRange;

    private void Start()
    {
        currentHealth = playerStats.MaxHealth;
        currentMovementSpeed = playerStats.MovementSpeed;
        currentStrength = playerStats.Strength;
        currentAttackSpeed = playerStats.AttackSpeed;
        currentAttackRange = playerStats.AttackRange;
    }
    
    public int CurrentHealth
    {
        get {return currentHealth;}
        set {currentHealth = value;}
    }
    public float CurrentMovementSpeed
    {
        get {return currentMovementSpeed;}
        set {currentMovementSpeed = value;}
    }
    public int CurrentStrength
    {
        get {return currentStrength;}
        set {currentStrength = value;}
    }
    public float CurrentAttackSpeed
    {
        get {return currentAttackSpeed;}
        set {currentAttackSpeed = value;}
    }
}
