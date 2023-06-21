using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlainsTile : EnvironmentTile
{
    public GameObject model;
    public int tileID;
    public Color tileColor;

    void Start() {
        // Assign values to the public fields
       // model = "";
        tileID = 2;
        tileColor = Color.green;

    }

    // Implementations of the Tile interface properties and methods
}
