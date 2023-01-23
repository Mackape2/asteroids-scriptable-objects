using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SettingsManager : ScriptableObject
{
    //First create a variable for the SettingsManager in you code
    //and then add the manager in unity to that variable in unity.
    
    //Then you simply call the variable that you wish to use in you code.
    
    // Ex. public SettingsManager Manager;
    //
    // var x = Manager.MaxForce;
    
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

        [Header("Controll")] 
        [Range(0, 10)] public float Throttle; 
        [Range(0, 10)] public float Roatation;



}
