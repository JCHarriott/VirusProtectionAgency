using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject floorPanel;

    int width = 6;
    int height = 3;

	// Use this for initialization
	void Start () {
		for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                GameObject tile_go = (GameObject) Instantiate(floorPanel, new Vector3(x, y, 0), Quaternion.identity);

                tile_go.name = "Tile_" + x + "_" + y;

                tile_go.GetComponent<Tile>().x = x;
                tile_go.GetComponent<Tile>().y = y;


                tile_go.transform.SetParent(this.transform);

                tile_go.isStatic = true;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
