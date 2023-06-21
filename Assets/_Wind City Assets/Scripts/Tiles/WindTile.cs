using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindTile : Tiles, Producer
{
    public GameObject model;
    public int tileID;
    public Color tileColor;

    void Start() {
        // Assign values to the public fields
       // model = "";
        tileID = 4;
        tileColor = Color.white;

    }

    // Implementations of the Tile interface properties and methods
}
