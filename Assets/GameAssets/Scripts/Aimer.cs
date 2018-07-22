using UnityEngine;
using System.Collections;

public class Aimer : MonoBehaviour
{
		public GameObject BulletPrefab;
		public int maxBullet = 4;
		public int numBullet = 0;
	public AudioClip shoot;
		private GameObject bullet;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.Space) && numBullet < maxBullet) {
						MakeBullet ();
			GetComponent<AudioSource>().PlayOneShot(shoot);
			
			
				}

		}
		void MakeBullet ()
		{
				bullet = (GameObject)Instantiate (BulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
				bullet.transform.rotation = this.transform.rotation;
				numBullet++;
		
		}

}
