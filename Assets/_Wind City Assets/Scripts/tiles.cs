using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    [SerializeField]
    protected Vector2 position = Vector2.zero;
    [SerializeField, Range(0.0f, 100.0f)]
    protected float environmentalCost = 0.0f;

	void Start()
    {
        
    }

    void Update()
    {
        
    }
}
