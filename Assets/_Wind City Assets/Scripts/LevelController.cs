using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LevelGenerator))]
public class LevelController : MonoBehaviour
{
    [Header("Tile Settings")]
    [SerializeField]
    private float energyRequiredScalar = 1.0f;
    [SerializeField]
    private int startingMoney = 10000;

    [SerializeField]
    private List<List<Tile>> levelGrid;


    private LevelGenerator levelGenerator;

	private void Awake()
	{
        levelGenerator = GetComponent<LevelGenerator>();

        levelGrid = levelGenerator.GenerateLevel();
	}
}
