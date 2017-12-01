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

public class JungleController : MonoBehaviour {

	//Public properties
	//how fast the jungle is moving
	[SerializeField]
	private float speed = 0.5f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;

	//private variables
	//accesse to transform keep traking of position,rotation,scale
	private Transform _transform;
	//keep traking of parent position
	//2D--->> vector2
	private Vector2 _currentPos;

	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = _transform.position;
		Reset ();
	}



void Update () {
		_currentPos = _transform.position;

	/**
	 * moveing the game object left the screen by speed px every frame
    */
		_currentPos -= new Vector2 (speed, 0);

		//check if we need to reset
		if (_currentPos.x < endX) {
			//reset
			Reset ();
		}
		//apply changes
		//new object
		_transform.position = _currentPos;

	}


	private void Reset(){

		_currentPos = new Vector2 (startX, 0);
	}
}


