using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_actions : MonoBehaviour {

	public resource_manager rm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void press_gold(){
		rm.gold += 1000;
	}
}
