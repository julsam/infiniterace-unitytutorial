using UnityEngine;
using System.Collections;

public class PickUpCollision : MonoBehaviour
{
	void Start()
	{
		
	}

	void Update()
	{
		
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "Player")
		{
			GetComponent<PickUpBehavior>().Picked();
			Destroy(gameObject);
		}

		if (collision.transform.parent == null) return;
		
		if (collision.transform.parent.tag == "Building")
		{
			Destroy(gameObject);
		}
	}
}
