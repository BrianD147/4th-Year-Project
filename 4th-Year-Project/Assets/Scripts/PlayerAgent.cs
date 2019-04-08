using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class PlayerAgent : Agent {

	public Rigidbody rBody; // used to access the player rigidbody

    public float speed = 10; // used to apply a movement speed to the player
    private float previousDistance = float.MaxValue; // used to store the previous distance to target in order to determine if the player is moving closer the target

    public float kickPower; // Used to apply a kick to the ball

    public Transform Target; // used to keep track of the target (ball)

    void Start () {
        rBody = GetComponent<Rigidbody>(); // access the player rigidbody
    }


    // function is used to reset the player if they fall off the platform, and move the target once it is reached
    // (have added walls bordering the pitch, and set up the player to kick the ball, so this function isn't used anymore)
    public override void AgentReset()
    {
        if (this.transform.position.y < -2.0) // If the players vertical position falls below the platform
        {
            // The Agent fell
            // Set the players position, angular velocity, and velocity to zero
            this.transform.position = Vector3.zero;
            this.rBody.angularVelocity = Vector3.zero;
            this.rBody.velocity = Vector3.zero;
        }
        else
        {
            // Move the target to a new spot
            //Target.position = new Vector3(Random.value * 8 - 4, -0.7f, Random.value * 8 - 4);
        }
    }

    // function observed the overall environment collecting data for the player to use
    // values are currently being divided by 5 to normalize the inputs to the neural network to the range [-1, 1]
    public override void CollectObservations()
    {
        // Calculate relative position of the target (ball) in relation to the player
        Vector3 relativePosition = Target.position - this.transform.position;

        //Debug.Log(relativePosition.x);

        // Relative position
        AddVectorObs(relativePosition.x/5);
        AddVectorObs(relativePosition.z/5);

        // Distance to edges of platform (a 10x10 area for now)
        // (Not set up correctly, actual floor size needs to be calculated)
        AddVectorObs((this.transform.position.x + 5)/5);
        AddVectorObs((this.transform.position.x - 5)/5);
        AddVectorObs((this.transform.position.z + 5)/5);
        AddVectorObs((this.transform.position.z - 5)/5);

        // Agent velocity
        // (This will help the agent learn to control his speed)
        AddVectorObs(rBody.velocity.x/5);
        AddVectorObs(rBody.velocity.z/5);
    }

    // function manages the control of the player and the reward logic
    public override void AgentAction(float[] vectorAction, string textAction)
    {
        // Rewards
        // calculates the distance to the target
        float distanceToTarget = Vector3.Distance(this.transform.position,
                                                Target.position);

        // Reached target
        // when the distance between player and target is less than 1.42f
        if (distanceToTarget < 1.42f)
        {
            AddReward(1.0f); // add 1 to the reward
            Done();
        }

        // Time penalty
        AddReward(-0.005f);

        // Fell off platform
        if (this.transform.position.y < -2.0)
        {
            AddReward(-1.0f);
            Done();
        }

        // Actions for movement
        Vector3 controlSignal = Vector3.zero; // Vector3 to detect intended movement direction
        controlSignal.x = vectorAction[0]; // applies the parameter value of vectorAction[0] to the x axis
        controlSignal.z = vectorAction[1]; // applies the parameter value of vectorAction[1] to the z axis
        rBody.AddForce(controlSignal * speed); // applies the movement speed to the direction specifies in the Vector3
        //Debug.Log(vectorAction[0] + " : " + vectorAction[1] + " --- " + controlSignal);
    }

    // detects collisions between the player and other colliders
    // (currently only used to apply a kick to the ball)
    void OnCollisionEnter(Collision c)
    {
        float force = 2000f * kickPower; // the force that will be applied to the kick

        // if the collision is with the ball
        if (c.gameObject.tag == "ball")
        {
            Vector3 dir = c.contacts[0].point - transform.position; // finds the direction the ball should be hit by going between the point of contact between the player and ball, and the position of the player when the contact occured
            dir = dir.normalized; // normalize the dir value
            c.gameObject.GetComponent<Rigidbody>().AddForce(dir * force); // apply the force to the ball in the correct direction
        }

        //If the player collides with the slopes on the sides, ignore them as we dont want the player getting stuck to the slope - only needed so the ball does not get stuck
        if (c.gameObject.tag == "slope")
        {
            Physics.IgnoreCollision(c.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        }

    }
}
