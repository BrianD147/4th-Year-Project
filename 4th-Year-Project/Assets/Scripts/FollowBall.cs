using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour {

	public float speed;
	private GameObject ball;

	// Use this for initialization
	void Start () {
		ball = GameObject.FindWithTag("ball");
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, ball.transform.position, step);
	}
}
