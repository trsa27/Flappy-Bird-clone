﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartMenuLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
			{
				
				UnityEngine.SceneManagement.SceneManager.LoadScene("PlayGameScene");
			}
	}
}
