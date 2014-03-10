using UnityEngine;
using System.Collections;

public class DeathExplosion : MonoBehaviour
{
	public GameObject prefabExplosion;

	void Start()
	{
	}

	void Update()
	{
		
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "Beast")
		{
			// call death in the beast script
			collision.gameObject.GetComponent<BeastDeath>().Death();

			Instantiate(prefabExplosion, transform.position, Quaternion.identity);
			Data.shipAlive = false;
			Destroy(this.gameObject);
		}

		if (collision.transform.parent == null) return;
		
		if (collision.transform.parent.tag == "Building")
		{
			Instantiate(prefabExplosion, transform.position, Quaternion.identity);
			Data.shipAlive = false;
			Destroy(this.gameObject);
		}
	}
}
