using UnityEngine;
using System.Collections;

public class DistanceTravelled : MonoBehaviour {

	public static float distanceTravelled(){
		return Mathf.RoundToInt (
			((ballMovement.distanceTravelled + 500)) / 400);
	}

		


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
