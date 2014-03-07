using UnityEngine;
using System.Collections;

public class DestructorWall : MonoBehaviour
{
	void OnTriggerEnter (Collider other)
	{
		if (other.transform.parent == null) return;

		if (other.transform.parent.tag == "Building") {
			Destroy(other.transform.parent.gameObject);
		}
	}
}
