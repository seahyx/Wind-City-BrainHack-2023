using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverTile : EnvironmentTile
{
    public GameObject model;
    public int tileID;
    public Color tileColor;

    void Start() {
        // Assign values to the public fields
       // model = "";
        tileID = 3;
        tileColor = Color.blue;

    }

    // Implementations of the Tile interface properties and methods
}
