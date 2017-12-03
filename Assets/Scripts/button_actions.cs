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

	public void send_adventurer(){
		if (rm.adventurer_parties > 0) {
			rm.adventurer_parties -= 1;
			Instantiate (rm.adventurers);
		}
	}

	public void press_gold(){
		rm.gold += 1;
	}

	public void buy_adventurers(){
		if (rm.gold >= 100) {
			rm.gold -= 100;
			rm.adventurer_parties += 1;
			rm.total_adventurer_parties += 1;
		}
	}
}
