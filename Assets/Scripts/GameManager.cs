using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	private GUIStyle textColor;

	void Update()
	{
		if (Input.GetKey("r"))
		{
			Reload ();
		}
	}

	void Start()
	{
		textColor = new GUIStyle();
		textColor.normal.textColor = Color.black;
	}

	void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 100, 50), "Score : " + Data.score, textColor);
	}

	public void Reload()
	{
		Application.LoadLevel(Application.loadedLevel);
		Data.score = 0;
	}
}
