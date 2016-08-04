using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float targetTime = 0.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
			if (targetTime > 0)
			{
				targetTime -= Time.deltaTime;
				if (targetTime < 0.0f)

				{
					LoadNextScene ();
				}
		//float tells us number of seconds that has elapsed since last update
		}
	}

	public void LoadNextScene()
	{
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);
	
	}

	public void LoadPreviousScene()
	{
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex - 1);

	}
			
}
