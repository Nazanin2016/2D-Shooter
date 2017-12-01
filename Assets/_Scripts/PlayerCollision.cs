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

 public class PlayerCollision : MonoBehaviour {


	[SerializeField] GameController gameController;

	[SerializeField] GameObject explosion;

	//variables for access to canves, sounds
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
			//Adding points
			gameController.Score += 100;
			other.gameObject.GetComponent<StarController> ().Reset ();

		} else if (other.gameObject.tag == "Eveil_1") {
			Debug.Log ("Collision Eveil_1\n");

			//decreasing pHealth after collision with enemy;
			gameController.Health -= 1;

			//var foe expolotion enemy1
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
			//lossing life
			gameController.Health -= 1;

			//var foe expolotion enemy2
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