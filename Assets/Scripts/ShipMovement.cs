using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour
{
	public float speedX = 5.0f;
	public float speedZ = 10.0f;

	private bool moving = false;
	private bool hasPlayedCameraMovement = false;
	public float forwardMovementOnDeath = 1.0f;

	void Start()
	{
		
	}

	void Update()
	{
		if (!Data.shipAlive)
		{
			if (!hasPlayedCameraMovement)
			{
				Vector3 newPos = transform.position;
				newPos.z += forwardMovementOnDeath;
				StartCoroutine(MoveFromTo(transform.position, newPos, 0.5f));
				hasPlayedCameraMovement = true;
			}
		}
		else
		{
			float dir = Input.GetAxis("Horizontal");

			if (Mathf.Abs(dir) > 0)
			{
				transform.position += new Vector3(dir * Time.deltaTime * speedX, 0, 0);
			}

			transform.position += new Vector3(0, 0, Time.deltaTime * speedZ);
		}
	}

	IEnumerator MoveFromTo(Vector3 pointA, Vector3 pointB, float time)
	{
		if (!moving)
		{ // Do nothing if already moving
			moving = true; // Set flag to true
			float t = 0f;
			while (t < 1.0f)
			{
				t += Time.deltaTime / time; // Sweeps from 0 to 1 in time seconds
				transform.position = Vector3.Lerp(pointA, pointB, t); // Set position proportional to t
				yield return null; // Leave the routine and return here in the next frame
			}
			moving = false; // Finished moving
		}
	}
}
