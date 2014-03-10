using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKey("r"))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
