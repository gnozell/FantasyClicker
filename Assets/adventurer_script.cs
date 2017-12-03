using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adventurer_script : MonoBehaviour {

	public float end_time;
	public int gold_reward;
	public resource_manager rm;

	private float current_time;

	// Use this for initialization
	void Start () {
		current_time = 0;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		current_time += Time.deltaTime;
		if (current_time > end_time) {
			if (rm != null) {
				rm.gold += gold_reward;
			}
			Debug.Log (current_time);
			Destroy (gameObject);
		}
	}
}
