using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {

		[SerializeField]
		float minYSpeed = 5f;
		[SerializeField]
		float maxYSpeed = 5f;
		[SerializeField]
		float minXSpeed = -5f;
		[SerializeField]
		float maxXSpeed = 5f;

		private Transform _transform;
		private Vector2 _currentSpeed;
		private Vector2 _currentPosition;

		// Use this for initialization
		void Start () {
			_transform = gameObject.GetComponent<Transform> ();
			Reset ();
		}

		public void Reset(){

			float xSpeed = Random.Range (minXSpeed, maxXSpeed);
			float ySpeed = Random.Range (minYSpeed, maxYSpeed);

			_currentSpeed = new Vector2 (xSpeed, ySpeed);

			float x = Random.Range (-280, 280); 
			_transform.position = 
				new Vector2 (x, 460 + Random.Range (-1, 1));

		}

		// Update is called once per frame
		void Update () {
			_currentPosition = _transform.position;
			_currentPosition -= _currentSpeed;
			_transform.position = _currentPosition;

			if (_currentPosition.y <= -450) {
				Reset ();
			}
		}

	public void OnTriggerEnter2D(Collider2D other){

			if (other.gameObject.tag == "Player") {
			Debug.Log ("COLLISION");
		}

	}

}

