using UnityEngine;
using System.Collections;

public class MidTurret : MonoBehaviour 

	{
		public GameObject BulletPrefab;
		
		public AudioClip shoot;
	public float shootTime;
	public int reload = 4;
		private GameObject bullet;
		
		// Use this for initialization
		void Start ()
		{
		shootTime = Time.time + reload;
		}
		
		// Update is called once per frame
		void Update ()
		{
			if (bullet == null && Time.time >shootTime) {
				MakeBullet ();
                GetComponent<AudioSource>().PlayOneShot(shoot);
				
				
			}
			
		}
		void MakeBullet ()
		{
			bullet = (GameObject)Instantiate (BulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
			
			
		}
		
	}