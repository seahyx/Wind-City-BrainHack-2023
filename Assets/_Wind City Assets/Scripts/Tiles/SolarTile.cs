using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarTile : Tiles, ProducerIF
{
    public GameObject model;
    public int tileID;
    public Color tileColor;

    void Start() {
        // Assign values to the public fields
       // model = "";
        tileID = 5;
        tileColor = Color.yellow;

    }

    // Implementations of the Tile interface properties and methods
}
