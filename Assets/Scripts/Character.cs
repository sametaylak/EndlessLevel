using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
	void Update () {
		GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 6);
	}
}
