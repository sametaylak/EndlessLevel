using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleManager : MonoBehaviour {
	public GameObject prefab;

	private float lastZ = 0f;

	void Start(){
		CreateTile ();
		CreateTile ();
		CreateTile ();
	}

	void CreateTile() {
		Instantiate(prefab, new Vector3(0,0,lastZ + 6), Quaternion.identity);
		lastZ += 6;
	}
}
