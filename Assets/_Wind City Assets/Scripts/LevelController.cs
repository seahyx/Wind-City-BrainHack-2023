using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [Header("Tile Prefabs")]
    [SerializeField]
    private List<Tile> forestTiles = new List<Tile>();
    [SerializeField]
    private List<Tile> plainsTiles = new List<Tile>();
    [SerializeField]
    private List<Tile> townTiles = new List<Tile>();
    [SerializeField]
    private List<Tile> renewableTiles = new List<Tile>();

    [Header("Tile Settings")]
    [SerializeField]
    private float energyRequiredScalar = 1.0f;

}
