using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


		private Vector2 position;
		private Transform transform;

		[SerializeField] public float speed;
		[SerializeField] private float downPos = -165f;
		[SerializeField] private float topPos = 165f; 
		[SerializeField] private float rightPos = 240f; 
		[SerializeField] private float leftPos = -240f; 


		void Start () {
			transform = gameObject.GetComponent<Transform> ();
			position = transform.position;
		}

		void Update () {

			if (Input.GetKey (KeyCode.W))
				position += new Vector2 (0, speed);
			if (Input.GetKey (KeyCode.S))
				position -= new Vector2 (0, speed);
			if (Input.GetKey (KeyCode.D))
				position += new Vector2 (speed, 0);
			if (Input.GetKey (KeyCode.A))
				position -= new Vector2 (speed, 0);

		if(Input.GetKey(KeyCode.UpArrow))
			position += new Vector2 (0, speed);
		if(Input.GetKey(KeyCode.DownArrow))
			position -= new Vector2 (0, speed);
		if(Input.GetKey(KeyCode.RightArrow))
			position += new Vector2 (speed, 0);
		if(Input.GetKey(KeyCode.LeftArrow))
			position -= new Vector2 (speed, 0);
		

			CheckBounds ();
			transform.position = position;
		}


		private void CheckBounds() {
			if (position.y < downPos)
				position.y = downPos;
			if (position.y > topPos)
				position.y = topPos;

			if (position.x < leftPos)
				position.x = leftPos;
			if (position.x > rightPos)
				position.x = rightPos;
		}
	}



