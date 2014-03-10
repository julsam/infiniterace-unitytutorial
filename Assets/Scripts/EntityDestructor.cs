using UnityEngine;
using System.Collections;

public class EntityDestructor : MonoBehaviour
{
	void OnTriggerEnter (Collider other)
	{
		if (other.transform.tag == "Beast") {
			Destroy(other.gameObject);
		}

		if (other.transform.parent == null) return;

		if (other.transform.parent.tag == "Building") {
			Destroy(other.transform.parent.gameObject);
		}
	}
}
