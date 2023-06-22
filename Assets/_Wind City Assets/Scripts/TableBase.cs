using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableBase : MonoBehaviour
{
	[SerializeField]
	private LevelGenerator levelGenerator;
	[SerializeField]
	private float margins = 0.05f; 

	public void UpdateTableSize()
	{
		if (levelGenerator == null) return;
		float sizeX = margins * 2 + levelGenerator.width * levelGenerator.tileScale;
		float sizeY = margins * 2 + levelGenerator.height * levelGenerator.tileScale;
		Vector3 newSize = new Vector3(sizeX, transform.localScale.y, sizeY);
		transform.localScale = newSize;
	}
}
