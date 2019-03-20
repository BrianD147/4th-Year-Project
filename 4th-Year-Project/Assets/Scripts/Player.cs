using UnityEngine;
using MLAgents;
using System.Collections.Generic;

namespace Player
{
    public class Player : Agent
    {
        public GameObject ball;
        public List<float> CollectState()
        {
            return new List<float> { transform.position.x, ball.transform.position.x };
        }

		private const int MoveLeft = 0;
        private const int MoveRight = 1;
        public float speed = 0.05f;

        public void AgentStep(float[] action)
        {
            if (action.Is(MoveLeft))
                Move(-speed);
            else if (action.Is(MoveRight))
                Move(speed);
        }
        private void Move(float delta)
        {
            transform.Translate(delta, 0, 0);
        }

		

		public int Deaths { get; private set; }
        public Transform minimumBounds;
        public Transform maximumBounds;
		/* 
        public override void AgentStep(float[] action)
        {
            if (OutOfBounds())
                AgentFailed();
        }
        private bool OutOfBounds()
        {
            return transform.position.x <= minimumBounds.position.x ||
                   transform.position.x >= maximumBounds.position.x;
        }
        private void AgentFailed()
        {
            reward = -1f;
            done = true;
            Deaths++;
        }
		*/
	}

	internal static class PlayersExtensions
		{
			public static bool Is(this float[] action, int actionType)
			{
				return (int)action[0] == actionType;
			}
		}
}