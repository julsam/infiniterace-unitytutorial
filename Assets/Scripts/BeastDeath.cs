using UnityEngine;
using System.Collections;

public class BeastDeath : MonoBehaviour
{
	public GameObject[] physicsGibs;
	public float explosionForce = 100;
	public float spawnRadius = 1.0f;

	void Start()
	{
	
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}

	public void Death()
	{
		Destroy(gameObject);

		// Explosion sang
		foreach (GameObject gib in physicsGibs)
		{
			GameObject gibInstance = Instantiate(gib, transform.position + Random.insideUnitSphere * spawnRadius, transform.rotation) as GameObject;
			gibInstance.rigidbody.AddExplosionForce(explosionForce, transform.position, spawnRadius);
		}

	}
}
