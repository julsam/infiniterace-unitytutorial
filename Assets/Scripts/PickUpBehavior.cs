using UnityEngine;
using System.Collections;

public enum PickUpType
{
	SCORE,
	WEAPONS,
	SHIELD
}

public class PickUpBehavior : MonoBehaviour
{
	public PickUpType type;

	void Start()
	{
		
	}
	
	void Update()
	{
		
	}

	public void Picked()
	{
		if (type == PickUpType.SCORE)
		{
			Debug.Log("SCORE");
			Data.score += 1;
		}
		else if (type == PickUpType.WEAPONS)
		{
			Debug.Log("WEAPONS");
		}
		else if (type == PickUpType.SHIELD)
		{
			Debug.Log("SHIELD");
		}

	}
}
