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

