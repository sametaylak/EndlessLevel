using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour {
	public GameObject prefab;

	private float lastZ = 12f;

	void Start(){
		PoolManager.instance.CreatePool (prefab, 10);
		PoolManager.instance.ReuseObject (prefab, new Vector3(0,0,0), Quaternion.identity);
		PoolManager.instance.ReuseObject (prefab, new Vector3(0,0,6), Quaternion.identity);
		PoolManager.instance.ReuseObject (prefab, new Vector3(0,0,12), Quaternion.identity);
	}

	void Reuse() {
		PoolManager.instance.ReuseObject (prefab, new Vector3(0,0,lastZ + 6), Quaternion.identity);
		lastZ += 6;
	}
}
