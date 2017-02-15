using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Jumps : MonoBehaviour {

	public static int jumps =1;

	public Text thisText;


	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void setJumps(){
		jumps++;
	}

	public static float getScore(){
		return jumps;

	}



	 


}
