using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrack : MonoBehaviour {

	public static int highestScore = 0;
	public static int redScore=0, blueScore=0;

	public Text redTeamScore;
	public Text blueTeamScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//HighScoreCheck();
		//WinCheck();
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
		//Debug.Log(blueScore);
		blueTeamScore.text = "" + blueScore;
	}

	public void RedScore(){
		redScore++;
		//Debug.Log(redScore);
		redTeamScore.text = "" + redScore;
	}

	void WinCheck(){
		if(highestScore == 5){
			Debug.Log("Win Win");
		}
	}
}
