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
//acssess to UI
using UnityEngine.UI;
//starting scene when push the restart botton 
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	//add variable to UI
	[SerializeField] Text health;
	[SerializeField] Text score;
	[SerializeField] Text gameOver;
	[SerializeField] Text highScore;
	[SerializeField] Button restart;
	[SerializeField] GameObject player;
	//adding variable
	private int gameScore;
	public int healthGame;
	public int gameHighScore;

	//public property 
	public int Score{
		get{ return gameScore; }
		set{gameScore = value;
			//update UI
			score.text = "Score: " + gameScore;

			gameHighScore = gameScore;

			highScore.text = "HighScore: " + gameHighScore;
		}
			
	}

	public int Health{
		get{ return healthGame; }
		set{ healthGame = value;
			if (healthGame <= 0) {_gameOver();
			}else{health.text = "Health: " + healthGame;
			}
		}
	}
	//make game over and restart disappear
	private void initialize(){

		Score = 0;
		Health = 5;

		gameOver.gameObject.SetActive (false);
		highScore.gameObject.SetActive (false);
		restart.gameObject.SetActive (false);
		health.gameObject.SetActive (true);
		score.gameObject.SetActive (true);
		player.SetActive (true);
	}

	private void _gameOver(){
		gameOver.gameObject.SetActive (true);
		highScore.gameObject.SetActive (true);
		restart.gameObject.SetActive (true);
		health.gameObject.SetActive (false);
		score.gameObject.SetActive (false);
		player.SetActive (false);
	}

	// Use this for initialization
	void Start () {
		initialize ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void ResetBtnClick(){

		SceneManager.
		LoadScene (
			SceneManager.GetActiveScene ().name);

	}

}


