/*The Sorce file name:Comp3064
 * Assignment1,2D Shooter
 * Author's name: Zahra Sadat Ale Hashem
 * Last modified by:Zahra sadat Ale Hashem
 * Date last modified:November 24 2017
 * program description: The Fairyland is a simple retro side-Scrolling shooter game.
 * The player can move up and down, right and left. The Evils come to kill Fairy in 2 directions,
 * up to down and right to left. The player must avoid killer Evils.
 * There are some Stars that give score when player catch them. 
 * The controls for this game are WASD and arrow keys. 
 * Reversion histori: #0.17
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//variable position
		private Vector2 position;
		private Transform transform;

	//acssess boundries for speed
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



