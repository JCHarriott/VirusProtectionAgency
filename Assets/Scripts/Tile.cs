using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public int x;
    public int y;

    public Tile[] GetNeighbours()
    {
        GameObject leftNeighbour = GameObject.Find("Tile_" + (x - 1) + "_" + y);
        GameObject rightNeighbour = GameObject.Find("Tile_" + (x + 1) + "_" + y);
        GameObject higherNeighbour = GameObject.Find("Tile_" + x + "_" + (y + 1));
        GameObject lowerNeighbour = GameObject.Find("Tile_" + x + "_" + (y - 1));

        return null;
    }
}
