using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimForGoal : MonoBehaviour {

	public float speed;
	private GameObject ball;
	private GameObject targetGoal;
	private Vector3 targetLocation;
	private GameObject targetPosition;

	// Use this for initialization
	void Start () {
		ball = GameObject.FindWithTag("ball");

		if(gameObject.tag == "bluePlayer"){
			Debug.Log("Blue Player");
			targetGoal = GameObject.FindWithTag("redGoal");
		} else if (gameObject.tag == "redPlayer"){
			Debug.Log("Red Player");
			targetGoal = GameObject.FindWithTag("blueGoal");
		}
		targetPosition = GameObject.FindWithTag("TargetPosition");
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;

		Vector3 dir = ball.transform.position - targetGoal.transform.position;
 		dir = dir.normalized;
		targetLocation = ball.transform.position + dir;

		//Debug.Log("Dir: " + dir);
		//Debug.Log("Ball: " + ball.transform.position);
		//Debug.Log("Target: " + targetLocation);

		//targetPosition.transform.position = targetLocation;
		transform.position = Vector3.MoveTowards(transform.position, targetLocation, step);
	}
}
