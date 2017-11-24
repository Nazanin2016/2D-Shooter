using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class PlayerCollision : MonoBehaviour {


	[SerializeField] GameController gameController;

	[SerializeField] GameObject explosion;

	private GameController _canvasController;
	private AudioSource _starSound;
	[SerializeField] AudioClip starAudioClip;

	// Use this for initialization
	void Start () {
		_starSound = gameObject.GetComponent<AudioSource> ();
		_canvasController = gameObject.GetComponent<GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other){


		if (other.gameObject.tag == "Star") {
			Debug.Log ("Collision Star\n");
			if (_starSound != null) {
				_starSound.PlayOneShot (starAudioClip);
			}
			//Destroy (other.gameObject);
			//Adding points
			gameController.Score += 100;
			other.gameObject.GetComponent<StarController> ().Reset ();

		} else if (other.gameObject.tag == "Eveil_1") {
			Debug.Log ("Collision Eveil_1\n");

			//decreasing pHealth after collision with enemy;
			gameController.Health -= 1;

			var expl = Instantiate (explosion);

			expl.GetComponent<Transform> ()
				.position = other.gameObject
					.GetComponent<Transform> ()
					.position;
			Destroy (expl, 0.5f);
			//enemy will disappear after collition
			other.gameObject.GetComponent<Eveil_1Controller> ().Reset ();

		} else if (other.gameObject.tag == "Eveil_2") { 
			Debug.Log ("Collision Eveil_2\n");

			gameController.Health -= 1;

			var expl = Instantiate (explosion);

			expl.GetComponent<Transform> ()
				.position = other.gameObject
					.GetComponent<Transform> ()
					.position;
			Destroy (expl, 0.5f);

			other.gameObject.
			GetComponent<Eveil_2Controller> ().Reset ();

	}

}
}