using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Debug.Log("Mouse Position: " + Input.mousePosition);

        //Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Debug.Log("World Point: " + worldPoint);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            GameObject hitObject = hitInfo.collider.transform.gameObject;
            Debug.Log("Raycast hit: " + hitObject.name);

            MeshRenderer mr = hitObject.GetComponentInChildren<MeshRenderer>();

            if (Input.GetMouseButtonDown(0))
            {    
                if(mr.material.color == Color.red)
                {
                    mr.material.color = Color.white;
                }
                else
                {
                    mr.material.color = Color.red;
                }
                
            }

        }


	}
}
