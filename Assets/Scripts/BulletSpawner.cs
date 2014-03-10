using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour
{
	public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Shoot"))
		{
			Instantiate(bullet, transform.position, Quaternion.identity);
		}
	}
}
