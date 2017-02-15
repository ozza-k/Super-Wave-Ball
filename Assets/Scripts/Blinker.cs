using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Blinker: MonoBehaviour {


	public Text flashingText; 
	// Use this for initialization
	void Start () {
		flashingText = GetComponent<Text> ();
		StartCoroutine (BlinkText ());

	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public IEnumerator BlinkText(){
		while (true) {
			flashingText.text = "";
			yield return new WaitForSeconds (0.5f);
			flashingText.text = ("Press SPACE");
			yield return new WaitForSeconds (0.5f); 
		}

	}


}
