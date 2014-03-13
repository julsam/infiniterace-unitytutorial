using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {

	public float timerDestru;

	// Use this for initialization
	void Start ()
	{
		Destroy(this.gameObject, timerDestru);	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
