using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour
{
	public GameObject prefabSpark;
	public float speed = 150.0f;
	// Use this for initialization
	void Start () {
	
	}

	void Update()
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

	
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "Beast")
		{
			// call death in the beast script
			collision.gameObject.GetComponent<BeastDeath>().Death();
			Destroy(this.gameObject);
		}

		if (collision.transform.parent == null) return;
		
		if (collision.transform.parent.tag == "Building")
		{
			Instantiate(prefabSpark, transform.position + Vector3.up * 1.25f, prefabSpark.transform.rotation);
			Destroy(this.gameObject);
		}
	}
}
