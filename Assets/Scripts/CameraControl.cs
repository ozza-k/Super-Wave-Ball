using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform ball;
	public float x;
	public float y;
	public float z;
	public float w;
	public int cameraHeight;
	public int cameraDistance;

	void Update(){
		
		this.transform.position = new Vector3 (ball.transform.position.x - cameraDistance, ball.transform.position.y + cameraHeight, ball.transform.position.z);
		this.transform.LookAt (ball);
		this.transform.localPosition = Vector2.MoveTowards (ball.transform.localPosition, new Vector3 (this.transform.localPosition.x, 30f, this.transform.localPosition.z), 100);


	}
}
