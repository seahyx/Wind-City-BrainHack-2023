using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumerTile : Tile
{
	public override TileSubtype tileSubtype { get; protected set; } = TileSubtype.Consumer;
}
