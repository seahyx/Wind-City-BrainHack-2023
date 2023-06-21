using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ConsType
{
    City,
}

public interface ConsumerIF : MonoBehaviour
{
    [SerializeField]
    protected Vector2 position = Vector2.zero;
    [SerializeField, Range(0.0f, 100.0f)]
    protected float environmentalCost = 0.0f;

    [SerializeField, Enum(typeof(ConsType))]
    protected ConsType type = ConsType.Forest;
	void Start()
    {
        
    }

    void Update()
    {
        
    }
}
