﻿using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

	public GameObject loadingImage;

	public void LoadScene(int level) {
		loadingImage.SetActive(true);
		Application.LoadLevel (level);
	}

	public static void LoadSceneNoImage(int level) {
		Application.LoadLevel(level);
	}

	public void QuitGame() {
		Application.Quit ();
	}
}
