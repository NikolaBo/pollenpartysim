using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableModel : MonoBehaviour
{
    GardenTile tile;
    private Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        tile = GetComponentInParent<GardenTile>();
        r = GetComponent<Renderer>();
    }

    public void OnMouseUp()
    {
        tile.setTile(MouseControl.getTile());
    }

    public void OnMouseEnter()
    {
        tile.previewTileStart(MouseControl.getTile());
    }

    public void OnMouseExit()
    {
        tile.previewTileStop();
    }
}
