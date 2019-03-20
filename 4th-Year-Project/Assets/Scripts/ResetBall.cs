using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision c)
    {
		Debug.Log(c);
        if (c.gameObject.tag == "redGoal")
        {
			transform.position = new Vector3(0f, 1.5f, 0f);
        }

		if (c.gameObject.tag == "blueGoal")
        {
			transform.position = new Vector3(0f, 1.5f, 0f);
        }

    }
}
