using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [Header("Tile Prefabs")]
    [SerializeField]
    private List<Tile> forestTiles = new List<Tile>();
    [SerializeField]
    private List<Tile> plainsTiles = new List<Tile>();
    [SerializeField]
    private List<Tile> cityTiles = new List<Tile>();
    [SerializeField]
    private List<Tile> riverTiles = new List<Tile>();
    [SerializeField]
    private Tile errorTile;

    [Header("Map Generation")]
    [SerializeField]
    private Texture2D map = Texture2D.whiteTexture;
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
    private float tileScale = 0.2f;

    public List<List<Tile>> GenerateLevel()
	{
        List<List<Tile>> levelGrid = new List<List<Tile>>();
        int width = map.width;
        int height = map.width;
        for (int y = 0; y < width; y++)
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

                newTile.transform.position = GetTilePosition(x, y, width, height, tileScale, Vector3.zero);
                newTile.transform.localScale = newTile.transform.localScale * tileScale;
                row.Add(newTile);
            }
            levelGrid.Add(row);
		}
        

        return levelGrid;
    }

    private Vector3 GetTilePosition(int x, int y, int width, int height, float tileScale, Vector3 offset)
	{
        return offset + new Vector3((x - (width / 2)) * tileScale, (y - (height / 2)) * tileScale);
	}
}
