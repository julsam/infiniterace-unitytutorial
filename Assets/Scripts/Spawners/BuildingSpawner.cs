using UnityEngine;
using System.Collections;

public class BuildingSpawner : MonoBehaviour
{
	public float spawnTimer = 2.0f;
	public GameObject[] buildings;
	public float frequency = 50;

	void Start()
	{
		Invoke("Spawn", 0);
	}

	public void Spawn()
	{
		if (!Data.shipAlive) return;

		// elle est pas utilise
		Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
		GameObject building = buildings[Random.Range(0, buildings.Length)];
		Vector3 randomPos = new Vector3(Random.Range(-frequency, frequency), 0, 0);
		Instantiate(building, transform.position + randomPos, Quaternion.identity);
		Invoke("Spawn", spawnTimer + Random.Range(0.0f, 1.0f));
	}
	
}
