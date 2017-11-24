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


