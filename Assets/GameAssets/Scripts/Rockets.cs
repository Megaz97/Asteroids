using UnityEngine;
using System.Collections;

public class Rockets : MonoBehaviour
{

		public GameObject Thruster;
	public AudioClip echoes;
		


		// Use this for initialization
		void Start ()
		{
				Thruster.transform.position = this.transform.position;
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				
				if (Input.GetKey (KeyCode.UpArrow)) {
						Thruster.SetActive (true);
                        GetComponent<AudioSource>().Play();
		
				} else {
						Thruster.SetActive (false);
				}
		}		
		
			
		

		

}
