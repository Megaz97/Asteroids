using UnityEngine;
using System.Collections;

public class Spaceship : MonoBehaviour
{
		//public Vector3 bullPos = new Vector3 (0, 0.5f, 0);
		public float speed = 10.0F;
		public float horizontalSpeed = 2.0F;
		public float verticalSpeed = 2.0F;
		public float rotationSpeed = 200.0F;

		void OnTriggerEnter2D (Collider2D other)
		{	
				if (!other.gameObject.CompareTag ("Bullet")) {
						Destroy (this.gameObject);
				}
		}

		void Start ()
		{
				
		}
	

		
		// Update is called once per frame
		void Update ()
		{


			
	
				if (Input.GetKey (KeyCode.LeftArrow))
						transform.Rotate (Vector3.forward, rotationSpeed * Time.deltaTime);

				if (Input.GetKey (KeyCode.RightArrow))
						transform.Rotate (-Vector3.forward, rotationSpeed * Time.deltaTime);

				if (Input.GetKey (KeyCode.UpArrow)) {
                    GetComponent<Rigidbody2D>().AddForce(transform.up * verticalSpeed * Time.deltaTime);
				}
				
	
				

			


		}
		


}