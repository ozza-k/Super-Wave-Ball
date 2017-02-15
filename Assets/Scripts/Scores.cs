using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Scores : MonoBehaviour {

	public static float score =0;

	public Text thisText;


	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setScore(float scr){
		score = scr; 
	}

	public static float getScore(){
		return score; 

	}

	public static void setCollectable(){
		score += 2000; 
	}


	public static void addScore(){
		score = score + ((DistanceTravelled.distanceTravelled()));
	}

	 



}
