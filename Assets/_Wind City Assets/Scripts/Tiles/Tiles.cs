using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tile : MonoBehaviour {
    public int x = 0;
    public int y = 0;

    public abstract TileSubtype tileSubtype { get; protected set; }
}