using UnityEngine;
using System.Collections;

public class BeastSpawner : MonoBehaviour
{
	public float spawnTimer = 2.0f;
	public GameObject[] beasts;
	public float frequency = 50;

	void Start()
	{
		Invoke("Spawn", 0);
	}

	public void Spawn()
	{
		if (!Data.shipAlive) return;

		Vector3 spawnPos = new Vector3(transform.position.x, beasts[0].transform.position.y, transform.position.z);
		GameObject beast = beasts[Random.Range(0, beasts.Length)];
		Vector3 randomPos = new Vector3(Random.Range(-frequency, frequency), 0, 0);
		Instantiate(beast, spawnPos + randomPos, Quaternion.identity);
		Invoke("Spawn", spawnTimer + Random.Range(0.0f, 1.0f));
	}
	
}
