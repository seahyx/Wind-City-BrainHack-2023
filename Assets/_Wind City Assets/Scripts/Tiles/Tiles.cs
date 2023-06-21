using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour{
    // Implementations of the ProducerIF interface properties
    public Vector2 Position { get; set; }
    public float CostPrice { get; set; }
    public float EnvironmentalCost { get; set; }

    // Additional methods and logic common to producer tiles
}