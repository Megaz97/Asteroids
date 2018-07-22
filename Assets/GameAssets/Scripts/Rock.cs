using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour
{
		public int movementSpeed = 2;
		GameManager gm;
	public int score;
	public AudioClip explode;


		// Use this for initialization
		void Start ()
		{

				
				transform.Rotate (0.0f, 0.0f, Random.Range (0.0f, 360.0f));
				gm = GameObject.Find ("GameManager").GetComponent<GameManager> ();
				gm.Count++;
			
		}
	
		// Update is called once per frame
		void Update ()
		{	
				
				
				//rigidbody2D.AddForce (transform.up * movementSpeed * Time.deltaTime);
				transform.Translate (Vector3.up * Time.deltaTime * movementSpeed);

		}
		void OnTriggerEnter2D (Collider2D other)
		{	
		if (other.gameObject.CompareTag ("Bounds")) {
			gm.Count--;
			Destroy(this.gameObject);

		}

		if (other.gameObject.CompareTag ("Bullet")) {


					
						
						if (this.transform.localScale.x > 0.25f) {
								for (int i = 0; i < 2; i++) {			
										gm.Rock (this.transform.position, this.transform.localScale.x / 2.0f);

								}	
								
						}
						
						
						if (this.transform.localScale.x >= 0.25f && this.transform.localScale.x <= 0.25f) {
								gm.score += 100;
						
						}
						if (this.transform.localScale.x >= 0.5f && this.transform.localScale.x <= 0.5f) {
								gm.score += 50;
								Debug.Log ("score:" + score);
                                GetComponent<AudioSource>().Play();
				
						}
						if (this.transform.localScale.x >= 1f && this.transform.localScale.x <= 1f) {
								gm.score += 20;
                                GetComponent<AudioSource>().Play();
								
								
				
						}
						gm.Count--;
						Destroy (this.gameObject);

		

				}



}
}

