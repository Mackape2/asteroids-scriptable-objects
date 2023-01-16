using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SettingsManager : ScriptableObject
{
    [Header("Asteroids")]
    [Header("Force")]
    [Range(0.1f, 0.4f)] public float MinForce;
    [Range(5f, 7f)] public float MaxForce;
    
    [Header("Size")]
    [Range(0.1f, 0.4f)] public float MinSize;
    [Range(0.8f, 1.1f)] public float MaxSize;
    
    [Header("Torgue")]
    [Range(0.1f, 0.4f)] public float MinTorque;
    [Range(0.5f, 1f)] public float MaxTorque;
    
    
    
    [Header("Ship")]
    
    [Header("Health")]
    public int MaxHealth;

     public int damageTaken = 0;

    public int CurrentHealth
    {
        get 
        { 
            return MaxHealth - damageTaken;
        }
    }

}
