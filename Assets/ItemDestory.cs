using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestory : MonoBehaviour {

	public GameObject unitychan;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 tmp = GameObject.Find ("unitychan").transform.position;
		float z = tmp.z - 10;

		if (transform.position.z < z) {
			Destroy (gameObject);
		}
	}
}
