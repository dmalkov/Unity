using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
	//ScoreKeeper type which is a Monobeahaviou

	public int score = 0;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void IncrementScore (int amount) 
	{
		score+= amount;
		//If score that comes in is 1, increment by 1; if is 2, increment by 2
		print ("You scored! Your current score is " + score);
	}
}
