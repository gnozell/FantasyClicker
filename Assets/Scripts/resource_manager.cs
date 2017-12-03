using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resource_manager : MonoBehaviour {

	public int gold = 0;
	public int weapons = 0;
	public int armor = 0;
	public int potions = 0;
	public int jewelry = 0;
	public int magic_items = 0;
	public int adventurer_parties = 0;
	public int total_adventurer_parties = 0;
	public int adventurer_reward = 100;

	public adventurer_script adventurers;


	public bool unlocked_weapons;
	public bool unlocked_armor;
	public bool unlocked_potion;
	public bool unlocked_jewelry;
	public bool unlocked_magic_items;


	public Text goldcounter;
	public Text adventurercounter;

	// Use this for initialization
	void Start () {
		adventurers.rm = this;
		adventurercounter.text = adventurer_parties.ToString ();
		
	}
	
	// Update is called once per frame
	void Update () {
		goldcounter.text = gold.ToString ();
		adventurercounter.text = total_adventurer_parties.ToString ();
		if (adventurer_parties > 0) {
			adventurer_parties -= 1;
			Instantiate (adventurers);
		}

	}
		
}
