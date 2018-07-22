using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
		public float bulletspeed = 10f;
		public float time = 0.8f;
		Aimer aa;
		// Use this for initialization 
		void Start ()
		{
				time += Time.time;
				aa = GameObject.Find ("Aimer").GetComponent<Aimer> ();
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				transform.Translate (Vector3.up * Time.deltaTime * bulletspeed);

				if (Time.time > time) {
						aa.numBullet--;
						Destroy (this.gameObject);
				}
		}
		void OnTriggerEnter2D (Collider2D other)
		{	
				if (!other.gameObject.CompareTag ("Player")) {

			
			
						aa.numBullet--;
						Destroy (this.gameObject);

			
			
			
			
				}
		}
}
