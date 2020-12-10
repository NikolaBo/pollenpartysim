using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGarden : MonoBehaviour
{
    [SerializeField] private int width = 5;
    [SerializeField] private int height = 5;
    [SerializeField] private float tileWidth = 5;
    private Vector3 pos;

    [SerializeField] private GameObject tile;
    private GameObject[,] grid;

    void Start()
    {
        pos = transform.position;
        Generate();
    }

    private void Generate()
    {
        grid = new GameObject[width, height];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector3 tilePosition = new Vector3(pos.x + tileWidth * i, pos.y, pos.z + tileWidth * j);
                grid[i, j] = Instantiate(tile, tilePosition, Quaternion.identity, transform);
            }
        }
    }

    public enum Tiles
    {
        DIRT,
        WATER,
        PLANT1,
        PLANT2,
        LOG
    }
}
