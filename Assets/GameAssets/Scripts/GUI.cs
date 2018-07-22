using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {
	GameManager gm;


	void OnGUI ()
	{
		GUILayout.Label ("     Score = " + gm.score);
		GUILayout.Label ("     Lives = " + gm.lives);
		
		
	}


	// Use this for initialization
	void Start () {
		gm = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad (transform.gameObject);
		if (Input.GetKeyUp ("r")) 
		{
						Destroy (this.gameObject);
			
			}
	}
}
