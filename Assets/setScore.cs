using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class setScore : MonoBehaviour {

	public Text thisText;
	// Use this for initialization
	void Start () {
		thisText.text = ("Score: "+ Scores.score.ToString());
		Scores.score = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
