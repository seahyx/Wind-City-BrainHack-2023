using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
    public int x = 0;
    public int y = 0;

    public virtual TileSubtype tileSubtype { get; protected set; } = TileSubtype.Error;
}