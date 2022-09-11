using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class GameStateManager : MonoBehaviour {

	public enum GameState {MainMenu, GameStart, GamePlaying, GameOver};
	
	public GameState state;
	// Use this for initialization
	void Awake()
	{
		state = GameState.MainMenu;
	}
	void Start () {
		
		
		GameObject.DontDestroyOnLoad(gameObject);
		GameObject.DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
		switch(state)
		{
			case GameState.MainMenu:
			if(Input.GetKeyDown(KeyCode.Space))
			{
				
				UnityEngine.SceneManagement.SceneManager.LoadScene("PlayGameScene");
			}
			break;
			case GameState.GameStart:
			break;
			case GameState.GamePlaying:
			break;
			case GameState.GameOver:
			break;
		}
	}
}
