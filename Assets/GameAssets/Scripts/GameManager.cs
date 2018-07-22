using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
		public GameObject[] RockPrefab;
		public int numRocks = 5;
		public GameObject rock;
		public Vector3 pos;
		public int score;
		public int Count;
		private GameObject player;
		public GameObject RocketPrefab;
	    public float respawnTime;
	public float appearTime;
	    public int lives = 3;
	public GameObject SaucerPrefab;
	public GameObject saucer;

		
		



	

		// Use this for initialization
		void Start ()
		{
		for (int i = 0; i < numRocks; i++) {
			pos = new Vector3 (Random.Range (-7F, 7F), Random.Range (-7F, 7F), 0);
			if (pos.x <= 6 && pos.x >= -6 && pos.y >= -3 && pos.y < 3 ) {
				
				i--;
				
			} else
				Rock (pos, 1.0f);
		}


		respawnTime = Time.time + 4f;
		appearTime = Time.time + 15f;
		Time.timeScale = 0;
				
				
				Character ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				//respawnTime = Time.time + 4f;
				
				if (Input.GetKeyUp ("p") && Time.timeScale == 0)
						Time.timeScale = 1;
				else if (Input.GetKeyUp ("p") && Time.timeScale == 1)
						Time.timeScale = 0;

				if (Count <= 2) {
			for (int i = 0; i < numRocks; i++) {
				pos = new Vector3 (Random.Range (-7F, 7F),Random.Range (-7F, 7F), 0);
				if (pos.x <= 6 && pos.x >= -6 && pos.y >= -3 && pos.y < 3 ) {
					
					i--;
					
				} else
					Rock (pos, 1.0f);
			}

					
				
				}
				

				if (player == null && Time.time >= respawnTime && lives > 0) {
			
						//Debug.Log (lives);
			
						Character ();
			
						lives--;

			
			
				}

		if (lives == 0 ) {
						Application.LoadLevel ("Game Over Asteroids");

				}
		if (saucer == null && Time.time > appearTime) {
			Alien ();
		}

		}

		public void Rock (Vector3 RockPos, float rockSize)
		{
				rock = Instantiate (RockPrefab [Random.Range (0, 4)], RockPos, Quaternion.identity) as GameObject;
				rock.transform.localScale = new Vector3 (rockSize, rockSize, 0f);

		}
		void Character ()
		{
				player = Instantiate (RocketPrefab, this.transform.position, Quaternion.identity) as GameObject;
		        respawnTime = Time.time + 4f;
		}
	void Alien ()
	{
		saucer = Instantiate (SaucerPrefab, new Vector3 (this.transform.position.x - 7f, this.transform.position.y + -3, this.transform.position.z), Quaternion.identity) as GameObject;
		appearTime = Time.time + 15f;
	}
		
}
