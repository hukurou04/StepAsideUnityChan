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
		if (transform.position.z < unitychan.transform.position.z) {
			Destroy (gameObject);
		}
	}
}
