﻿using UnityEngine;
using System.Collections;

public class GameOverDone : MonoBehaviour {




	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	
		if (Input.GetKeyUp ("r"))
		{
			Application.LoadLevel ("Asteroids");


		}

	}
}
