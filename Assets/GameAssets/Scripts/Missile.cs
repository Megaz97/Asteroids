using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {
		public float bulletspeed = 10f;
		public float time = 0.8f;
		Aimer aa;
		// Use this for initialization 
		void Start ()
		{
			time += Time.time;
			
		}
		
		// Update is called once per frame
		void Update ()
		{
			
			transform.Translate (Vector3.up * Time.deltaTime * bulletspeed);
			
			if (Time.time > time) {

				Destroy (this.gameObject);
			}
		}
		void OnTriggerEnter2D (Collider2D other)
		{	
			if (other.gameObject.CompareTag ("Player")) {
				
				
				

				Destroy (this.gameObject);
				
				
				
				
				
			}
		}
	}