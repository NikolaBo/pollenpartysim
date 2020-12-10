using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenTile : MonoBehaviour
{
    [SerializeField] private GameObject[] models;
    [SerializeField] private GameObject highlight;
    private GameObject currentModel;
    [SerializeField] private GridGarden.Tiles initialTile = GridGarden.Tiles.DIRT;
    private bool previewing = false;
    private GridGarden.Tiles tile;

    // Start is called before the first frame update
    void Start()
    { 
        foreach (GameObject m in models)
        {
            m.SetActive(false);
        }
        currentModel = models[initialTile.GetHashCode()];
        tile = initialTile;
        currentModel.SetActive(true);
    }

    public void setTile(GridGarden.Tiles tile)
    {
        if (tile.GetHashCode() >= models.Length)
        {
            Debug.LogError("There is no tile for enumerated value: " + tile);
            return;
        }
        currentModel.SetActive(false);
        currentModel = models[tile.GetHashCode()];
        currentModel.SetActive(true);
        this.tile = tile;
    }

    public void previewTileStart(GridGarden.Tiles tile)
    {
        highlight.SetActive(true);
        if (this.tile != tile)
        {
            currentModel.SetActive(false);
            currentModel = models[tile.GetHashCode()];
            currentModel.SetActive(true);
        }
    }

    public void previewTileStop()
    {
        currentModel.SetActive(false);
        currentModel = models[tile.GetHashCode()];
        currentModel.SetActive(true);
        highlight.SetActive(false);
    }
}
