using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProducerTile : Tile
{
	public override TileSubtype tileSubtype { get; protected set; } = TileSubtype.Producer;
}
