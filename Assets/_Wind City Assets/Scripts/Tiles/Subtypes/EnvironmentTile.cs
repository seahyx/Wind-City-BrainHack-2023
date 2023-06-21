using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentTile : Tile
{
	public override TileSubtype tileSubtype { get; protected set; } = TileSubtype.Environment;
}
