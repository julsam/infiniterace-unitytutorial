using UnityEngine;
using System.Collections;

public class PickUpSpawner : MonoBehaviour
{
	public float spawnTimer = 2.0f;
	public GameObject[] pickups;
	public float frequency = 50;
	
	void Start()
	{
		Invoke("Spawn", 0);
	}
	
	public void Spawn()
	{
		if (!Data.shipAlive) return;
		
		Vector3 spawnPos = new Vector3(transform.position.x, pickups[0].transform.position.y, transform.position.z);
		GameObject pickup = pickups[Random.Range(0, pickups.Length)];
		Vector3 randomPos = new Vector3(Random.Range(-frequency, frequency), 0, 0);
		Instantiate(pickup, spawnPos + randomPos, Quaternion.identity);
		Invoke("Spawn", spawnTimer + Random.Range(0.0f, 1.0f));
	}
}
