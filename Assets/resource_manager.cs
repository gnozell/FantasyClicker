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
	public int adventurer_parties = 1;


	public bool unlocked_weapons;
	public bool unlocked_armor;
	public bool unlocked_potion;
	public bool unlocked_jewelry;
	public bool unlocked_magic_items;





	public Text goldcounter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gold += 1;
		goldcounter.text = gold.ToString ();
		
	}
}
