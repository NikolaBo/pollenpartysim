using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    // The singleton instance
    private static MouseControl instance;
    private static MouseControl Instance { get { return instance; } }

    // The tile index to be assigned on click
    private static GridGarden.Tiles tile = GridGarden.Tiles.WATER;

    public void instanceSetTile(int tile)
    {
        setTile((GridGarden.Tiles)tile);
    }

    public static void setTile(GridGarden.Tiles tile)
    {
        MouseControl.tile = tile;
    }

    public static GridGarden.Tiles getTile()
    {
        return tile;
    } 
}
