using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimForGoal : MonoBehaviour {

	public float speed;
	private GameObject ball;
	private GameObject targetGoal;
	private Vector3 targetLocation;
	private GameObject targetPosition;
	
	private Vector3 redGoalArea = new Vector3(11, 0, 0);
	private Vector3 blueGoalArea = new Vector3(-11, 0, 0);

	// Use this for initialization
	void Start () {
		ball = GameObject.FindWithTag("ball");

		if(gameObject.tag == "bluePlayer" || gameObject.tag == "blueGoalie"){
			Debug.Log("Blue Player");
			targetGoal = GameObject.FindWithTag("redGoal");
		} else if (gameObject.tag == "redPlayer" || gameObject.tag == "redGoalie"){
			Debug.Log("Red Player");
			targetGoal = GameObject.FindWithTag("blueGoal");
		}
		targetPosition = GameObject.FindWithTag("TargetPosition");
	}
	
	// Update is called once per frame
	void Update () {
		

		Vector3 dir = ball.transform.position - targetGoal.transform.position;
 		dir = dir.normalized;
		targetLocation = ball.transform.position + dir;

		//Debug.Log("Dir: " + dir);
		//Debug.Log("Ball: " + ball.transform.position);
		//Debug.Log("Target: " + targetLocation);

		//targetPosition.transform.position = targetLocation;
		if(gameObject.tag == "bluePlayer"){
			if(ball.transform.position.x > redGoalArea.x){
				Debug.Log("Red Goal Area");
			}else{
				Move();			
			}
		}
		if(gameObject.tag == "redPlayer"){
			if(ball.transform.position.x < blueGoalArea.x){
				Debug.Log("Blue Goal Area");
			}else{
				Move();			
			}
		}
		if(gameObject.tag == "blueGoalie"){
			if(ball.transform.position.x < blueGoalArea.x){
				//Debug.Log("Blue Goal Area");
				Move();			
			}
		}
		if(gameObject.tag == "redGoalie"){
			if(ball.transform.position.x > redGoalArea.x){
				//Debug.Log("Red Goal Area");
				Move();
			}
		}
	}

	void Move(){
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, targetLocation, step);
	}
}
