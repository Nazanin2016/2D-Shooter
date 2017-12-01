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

public class Eveil_1Controller : MonoBehaviour {

	//acssess boundries for speed
	[SerializeField]
	float minYSpeed = 3f;
	[SerializeField]
	float maxYSpeed = -3f;
	[SerializeField]
	float minXSpeed = 5f;
	[SerializeField]
	float maxXSpeed = 10f;

	private Transform _transform;
	private Vector2 _currentSpeed;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		//get transform from object
		_transform = gameObject.GetComponent<Transform> ();
		Reset ();
	}

	//reset function
	public void Reset(){
		
		//send the enemy to the scene. calculate new speed
		float xSpeed = Random.Range (minXSpeed, maxXSpeed);
		float ySpeed = Random.Range (minYSpeed, maxYSpeed);
		_currentSpeed = new Vector2 (xSpeed, ySpeed);

		//move the enemy to right and left
		float y = Random.Range (-190, 190); 
		_transform.position = new Vector2 (300, y + Random.Range (0, 100));

	}

	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed;
		_transform.position = _currentPosition;
		//update for reset function
		if (_currentPosition.x <= -600) {
			Reset ();
		}
	}


		public void OnTriggerEnter2D(Collider2D other){

			if (other.gameObject.tag == "Player") {
				Debug.Log ("COLLISION");
			}
	}
}

