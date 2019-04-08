using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrack : MonoBehaviour {

	public static int highestScore = 0;
	public static int redScore=0, blueScore=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		HighScoreCheck();
		WinCheck();
	}

	void HighScoreCheck(){
		if(blueScore > highestScore){
			blueScore = highestScore;
		}
		if(redScore > highestScore){
			redScore = highestScore;
		}
	}

	public void BlueScore(){
		blueScore++;
		Debug.Log(blueScore);
	}

	public void RedScore(){
		redScore++;
		Debug.Log(redScore);
	}

	void WinCheck(){
		if(highestScore == 5){
			Debug.Log("Win Win");
		}
	}
}
