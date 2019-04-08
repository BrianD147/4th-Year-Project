using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetBall : MonoBehaviour {

	public static int redScore = 0;
	public static int blueScore = 0;
	Text redTeam;
	Text blueTeam;
	ScoreTrack sc = GetComponent<ScoreTrack>();

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//blueTeam.text = "" + blueScore;
		//redTeam.text = "" + redScore;
	}

	void OnCollisionEnter(Collision c)
    {
		Debug.Log(c);
        if (c.gameObject.tag == "redGoal")
        {
			transform.position = new Vector3(0f, 1.5f, 0f);
			blueScore++;
			sc.BlueScore();
			Debug.Log(blueScore);
        }

		if (c.gameObject.tag == "blueGoal")
        {
			transform.position = new Vector3(0f, 1.5f, 0f);
			redScore++;
			Debug.Log(redScore);
        }
    }
}
