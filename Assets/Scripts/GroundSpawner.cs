using UnityEngine;
using System.Collections;

public class GroundSpawner : MonoBehaviour
{
	public GameObject groundSpawner;
	public GameObject ship;
	private GameObject ground;
	public float distanceToCheck = 150.0f;
	private bool alreadySpawned = false;

	void Start()
	{
		ground = transform.GetChild(0).gameObject;
		Invoke("Remove", 30);
	}

	void Update()
	{
		if (!Data.shipAlive) return;

		//float distance = Vector3.Distance(transform.position, ship.transform.position);
		float zDistance = transform.position.z - ship.transform.position.z;

		if (zDistance < distanceToCheck && !alreadySpawned)
		{
			// spawn
			float zSize = ground.collider.bounds.size.z;
			Vector3 newPosition = new Vector3(ship.transform.position.x, 0, transform.position.z + zSize);
			Instantiate(groundSpawner, newPosition, Quaternion.identity);
			alreadySpawned = true;
		}
	}

	private void Remove()
	{
		if (!Data.shipAlive) {
			Destroy(gameObject);
		}
	}
}
