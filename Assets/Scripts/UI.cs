using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UI : MonoBehaviour {

	public Text scoreText;
	public Text jumpText;
	public Text gameOverText;
	public int scoreVar = 10;
	public bool stopped = false; 
	public float time=0;

	// Use this for initialization
	void Start () {
		gameOverText.gameObject.SetActive (false);
		Scores.score = 10;
	}

	// Update is called once per frame
	void Update () {
		AddToScore ();
		SetScoreText ();
		SetJumpText ();
		if(time>0 && time == Time.fixedTime -1){
			scoreText.text = "Game Over";
		}

	}

	void AddToScore()
	{
		Scores.addScore ();
		
			
	}

	void SetJumpText(){
		jumpText.text = "Jumps: " + Jumps.jumps.ToString ();
	}


	void SetScoreText ()
	{
		scoreText.text = "Score:" + Scores.score.ToString ();
	}

	void GameOver(){
		gameOverText.gameObject.SetActive (true);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Collectible")) {
			other.gameObject.SetActive (false);

		}
	}


	public void collected(){
		scoreText.text = ("Collecated"); 
	}

}


