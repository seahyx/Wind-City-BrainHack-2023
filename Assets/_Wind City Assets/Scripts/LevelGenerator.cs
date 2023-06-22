using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelGenerator : MonoBehaviour
{
    [Header("Tile Prefabs")]
    [SerializeField]
    private List<EnvironmentTile> forestTiles = new List<EnvironmentTile>();
    [SerializeField]
    private List<EnvironmentTile> plainsTiles = new List<EnvironmentTile>();
    [SerializeField]
    private List<ConsumerTile> cityTiles = new List<ConsumerTile>();
    [SerializeField]
    private List<EnvironmentTile> riverTiles = new List<EnvironmentTile>();
    [SerializeField]
    private Tile errorTile;

    [Header("Map Generation")]
    [SerializeField]
    private Texture2D map;
    [SerializeField]
    private Color cityTileCol = Color.grey;
    [SerializeField]
    private Color forestTileCol = new Color(0, 0.5f, 0);
    [SerializeField]
    private Color plainsTileCol = Color.green;
    [SerializeField]
    private Color riverTileCol = Color.blue;
    [SerializeField]
    private Transform parent;
    [SerializeField]
    public float tileScale = 0.2f;
    [SerializeField]
    public int randomSeed = 1005966;

    [Header("Events")]
    [SerializeField]
    private UnityEvent onLevelGenerate = new UnityEvent();

    public int width => map.width;
    public int height => map.height;

    public List<List<Tile>> GenerateLevel()
	{
        List<List<Tile>> levelGrid = new List<List<Tile>>();
        int width = map.width;
        int height = map.height;

        Random.InitState(randomSeed);

        for (int y = 0; y < height; y++)
        {
            List<Tile> row = new List<Tile>();
            for (int x = 0; x < width; x++)
		    {
                Tile newTile = new Tile();
                Color pixel = map.GetPixel(x, y);
                if (pixel == cityTileCol)
				{
                    newTile = Instantiate(cityTiles[0], parent);
				} else if (pixel == forestTileCol)
				{
                    newTile = Instantiate(forestTiles[0], parent);
                } else if (pixel == plainsTileCol)
				{
                    newTile = Instantiate(plainsTiles[0], parent);
                } else if (pixel == riverTileCol)
				{
                    newTile = Instantiate(riverTiles[0], parent);
                } else {
                    newTile = Instantiate(errorTile, parent);
                }
                newTile.x = x;
                newTile.y = y;
                newTile.transform.localPosition = GetTilePosition(x, y, width, height, tileScale, Vector3.zero);
                newTile.transform.localScale = newTile.transform.localScale * tileScale;

                // Randomize rotation
                float randVal = Random.Range(0.0f, 4.0f);
                if (randVal < 1.0f)
                {
                    newTile.transform.Rotate(new Vector3(0, 90));
                } else if (randVal < 2.0f)
				{
					newTile.transform.Rotate(new Vector3(0, 180));
				}
				else if (randVal < 3.0f)
				{
					newTile.transform.Rotate(new Vector3(0, 270));
				}

				row.Add(newTile);
            }
            levelGrid.Add(row);
		}

        onLevelGenerate.Invoke();

        return levelGrid;
    }

    private Vector3 GetTilePosition(int x, int y, int width, int height, float tileScale, Vector3 offset)
	{
        return offset + new Vector3((x - ((width - 1) / 2.0f)) * tileScale, 0, (y - ((height - 1) / 2.0f)) * tileScale);
	}
}
