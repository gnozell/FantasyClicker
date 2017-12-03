using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_logo : MonoBehaviour {

	public float speed = 2f;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 10f) {
			Vector3 oldposition = transform.position;
			transform.position = new Vector3 (-10f, oldposition.y, oldposition.z);
		}
		transform.position += new Vector3 (.01f * speed,0,0);
	}
}
