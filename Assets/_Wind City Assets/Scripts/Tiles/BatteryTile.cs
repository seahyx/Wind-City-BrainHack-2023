using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryTile : Tiles, ProducerIF
{
    public GameObject model;
    public int tileID;
    public Color tileColor;

    void Start() {
        // Assign values to the public fields
       // model = "";
        tileID = 6;
        tileColor = Color.grey;

    }

    // Implementations of the Tile interface properties and methods
}
