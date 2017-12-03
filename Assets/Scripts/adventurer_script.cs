using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adventurer_script : MonoBehaviour {

	public int gold_reward;
	public float end_time;
	public resource_manager rm;

	public GameObject adventurer;
	public Sprite Adven1;
	public Sprite Adven2;
	public Sprite Adven3;

	public Transform start_point;
	public Transform end_point;

	private float current_time;
	private float halfwaytime;
	private float journeyLength;
	private float start_time;

	private GameObject myadventurer;

	// Use this for initialization
	void Start () {
		int SpritePick = Random.Range (0, 3);
		if (SpritePick == 0) {
			adventurer.GetComponent<SpriteRenderer> ().sprite = Adven1;
		} else if (SpritePick == 1) {
			adventurer.GetComponent<SpriteRenderer>().sprite = Adven2;
		} else if (SpritePick == 2) {
			adventurer.GetComponent<SpriteRenderer>().sprite = Adven3;
		}

		current_time = 0;
		halfwaytime = end_time / 2;
		start_time = Time.time;
		journeyLength = Vector3.Distance(start_point.position, end_point.position);
		myadventurer = Instantiate (adventurer, start_point.position, transform.localRotation, transform);
		
	}

	// Update is called once per frame
	void Update () {
		current_time += Time.deltaTime;
		if (current_time > end_time) {
			if (rm != null) {
				rm.gold += gold_reward;
				rm.adventurer_parties += 1;
			}
			Destroy (gameObject);
		}

		if (current_time < halfwaytime) {
			float distCovered = (Time.time - start_time);
			float fracJourney = distCovered / halfwaytime;
			myadventurer.transform.position = Vector2.Lerp (start_point.position, end_point.position, fracJourney);
		} else {
			float distCovered = (Time.time - start_time - halfwaytime);
			float fracJourney = distCovered / halfwaytime;
			myadventurer.transform.position = Vector2.Lerp (end_point.position, start_point.position, fracJourney);
		}
	}
}
