﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name) {
		Debug.Log("Level load requested for: " + name);
		Application.LoadLevel(name);
	}
	
	public void RequestQuit () {
		Debug.Log("Quit requested");
		Application.Quit();
	}

}
