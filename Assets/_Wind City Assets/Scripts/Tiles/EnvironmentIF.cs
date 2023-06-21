using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EnvType
{
    Forest,
    Plains,
    River,
}

public interface EnvironmentIF 
{
    [SerializeField]
    protected Vector2 position = Vector2.zero;
    [SerializeField, Range(0.0f, 100.0f)]
    protected float environmentalCost = 0.0f;
    [SerializeField, Enum(typeof(EnvType))]
    protected EnvType type = EnvType.Forest;

	void Start()
    {
        
    }

    void Update()
    {
        
    }
}
