using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : PoolObject {
	void Update () {
		
	}

	public override void OnObjectReuse() {
		
	}

	void OnTriggerEnter(Collider col) {
		FindObjectOfType<TestManager> ().SendMessage ("Reuse");
	}
}
