using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleObject : MonoBehaviour {
	void OnTriggerEnter(Collider col) {
		FindObjectOfType<SimpleManager> ().SendMessage ("CreateTile");
	}
}
