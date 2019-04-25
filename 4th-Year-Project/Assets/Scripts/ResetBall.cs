using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetBall : MonoBehaviour {

	private GameObject canvas;
	private ScoreTrack sc;

	private GameObject blueGoalie;
	private GameObject redGoalie;
	private GameObject bluePlayer;
	private GameObject redPlayer;
	private GameObject blueDefender;
	private GameObject redDefender;

	// Use this for initialization
	void Start () {
		canvas = GameObject.FindWithTag("canvas");
		sc = canvas.GetComponent<ScoreTrack>();

		blueGoalie = GameObject.FindWithTag("blueGoalie");
		redGoalie = GameObject.FindWithTag("redGoalie");
		bluePlayer = GameObject.FindWithTag("bluePlayer");
		redPlayer = GameObject.FindWithTag("redPlayer");
		blueDefender = GameObject.FindWithTag("blueDefender");
		redDefender = GameObject.FindWithTag("redDefender");
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
			ResetPlayers();
        }

		if (c.gameObject.tag == "blueGoal")
        {
			transform.position = new Vector3(0f, 1.5f, 0f);
			sc.RedScore();
			Debug.Log("Red Goal!");
        }
    }

	private Random random = new Random();

	float RandomNumberBetween(float minValue, float maxValue)
	{
	    float random = Random.Range(minValue, maxValue);

	    return random;
	}

	void ResetPlayers(){
		float Offset;
		blueGoalie.transform.position = new Vector3(-13, 0, 0);
		redGoalie.transform.position = new Vector3(13, 0, 0);

		Offset = RandomNumberBetween(-5, -1);
		bluePlayer.transform.position = new Vector3(Offset, 0, -1);
		Offset = RandomNumberBetween(1, 5);
		redPlayer.transform.position = new Vector3(Offset, 0, 1);

		Offset = RandomNumberBetween(-8, -4);
		blueDefender.transform.position = new Vector3(Offset, 0, 1);
		Offset = RandomNumberBetween(4, 8);
		redDefender.transform.position = new Vector3(Offset, 0, -1);
	}
}
