using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

	LevelManager timeDisplay;
	Text text;

	// Use this for initialization
	void Start () {

		timeDisplay = FindObjectOfType<LevelManager> ();
		text = GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Time Remaining: " + timeDisplay.targetTime;
	
	}
}
