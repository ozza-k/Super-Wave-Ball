using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ballMovement : MonoBehaviour {


	public int forwardSpeed =0;
	public int turnSpeed = 0;
	public int jumpHeight = 1;

	public Transform player;
	public static float distanceTravelled;
	public Rigidbody ball;

	// Use this for initialization
	void Start () {
		ball = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () { 
		ball.velocity = new Vector3 (1 * forwardSpeed * Time.deltaTime, 0, 0);

		if (Input.GetKey (KeyCode.RightArrow)) {
			ball.velocity = new Vector3 (1 * forwardSpeed * Time.deltaTime, 0, -1 * turnSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			ball.velocity = new Vector3 (1 * forwardSpeed * Time.deltaTime, 0, 1 * turnSpeed * Time.deltaTime);
		}

		distanceTravelled = transform.localPosition.x;

		jumpCaller ();
	}


	public void jumpCaller(){

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (Jumps.jumps > 0) {
				StartCoroutine(jumpBall()); 
				Jumps.jumps--; 
			}

		}



	}

	public IEnumerator jumpBall(){
		ball.transform.Translate (Vector3.up*4, 0); 
		yield return new WaitForSeconds (0.5f); 
		ball.transform.Translate (Vector3.down*4, 0);
	}






	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Obstacle")) {
			GameOver ();
		}

		if (other.gameObject.CompareTag ("Collectible")) {
			other.gameObject.SetActive (false);
			Jumps.setJumps ();
		}

		if (other.gameObject.CompareTag ("Points")) {
			other.gameObject.SetActive (false);
			Scores.setCollectable (); 
		}


	}

	void GameOver ()
	{
		forwardSpeed = 0;
		turnSpeed = 0;
		Jumps.jumps = 1; 

		Application.LoadLevel ("GameOverScene");

	}
}