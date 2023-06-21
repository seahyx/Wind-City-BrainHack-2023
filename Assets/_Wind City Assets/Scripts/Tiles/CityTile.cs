using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityTile : Tiles, Producer
{
    public GameObject model;
    public int tileID;
    public Color tileColor;

    void Start() {
        // Assign values to the public fields
       // model = "";
        tileID = 8;
        tileColor = Color.black;

    }

    // Implementations of the Tile interface properties and methods
}