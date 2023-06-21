using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ProdType
{
    Solar,
    Battery,
    Geothermal,
    Wind,
}
public interface ProducerIF 
{
    [SerializeField]
    protected Vector2 position = Vector2.zero;
    [SerializeField, Range(0.0f, 1000.0f)]
    protected float costprice = 0.0f;
    [SerializeField, Range(0.0f, 100.0f)]
    protected float environmentalCost = 0.0f;
    [SerializeField, Enum(typeof(ProdType))]
    protected ProdType type = ProdType.Solar;
	void Start()
    {
        
    }

    void Update()
    {
        
    }
}
