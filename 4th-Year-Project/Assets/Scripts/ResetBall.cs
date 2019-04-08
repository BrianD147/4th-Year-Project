using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetBall : MonoBehaviour {

	private GameObject canvas;
	private ScoreTrack sc;

	// Use this for initialization
	void Start () {
		canvas = GameObject.FindWithTag("canvas");
		sc = canvas.GetComponent<ScoreTrack>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision c)
    {
		//Debug.Log(c);
        if (c.gameObject.tag == "redGoal")
        {
			transform.position = new Vector3(0f, 1.5f, 0f);
			sc.BlueScore();
			Debug.Log("Blue Goal!");
        }

		if (c.gameObject.tag == "blueGoal")
        {
			transform.position = new Vector3(0f, 1.5f, 0f);
			sc.RedScore();
			Debug.Log("Red Goal!");
        }
    }
}
