using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleObject : MonoBehaviour {
	public GameObject obstacle;

	private GameObject spawner;

	void Start(){
		spawner = this.gameObject.transform.GetChild (1).gameObject;
	}

	void OnTriggerEnter(Collider col) {
		FindObjectOfType<SimpleManager> ().SendMessage ("CreateTile");
		Instantiate (obstacle, RandomPointInBox (spawner.transform.position), Quaternion.identity);
	}

	Vector3 RandomPointInBox(Vector3 center) {
		return center + new Vector3(
			Random.Range(-1.5f, 1.5f),
			0.5f,
			20f
		);
	}
}
