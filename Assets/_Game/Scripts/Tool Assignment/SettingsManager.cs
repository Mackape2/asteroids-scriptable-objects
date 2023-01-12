using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SettingsManager : ScriptableObject
{
    [Header("Asteroids")]
    [Header("Force")]
    [Range(0.1f, 0.4f)] [SerializeField] public float _minForce;
    [Range(5f, 7f)] [SerializeField] public float _maxForce;
    
    [Header("Size")]
    [Range(0.1f, 0.4f)][SerializeField] public float _minSize;
    [Range(0.8f, 1.1f)][SerializeField] public float _maxSize;
    
    [Header("Torgue")]
    [Range(0.1f, 0.4f)][SerializeField] public float _minTorque;
    [Range(0.4f, 0.6f)][SerializeField] public float _maxTorque;
}
