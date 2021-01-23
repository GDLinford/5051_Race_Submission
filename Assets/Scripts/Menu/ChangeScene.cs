using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

	void OnMouseOver() {
		Debug.Log("Clicked");
		if (Input.GetMouseButtonUp(0)) {
			LoadNextScene();
		}
	}

	public void LoadNextScene() {
		SceneManager.LoadScene(SceneManager.sceneCount +0);
		Debug.Log("Scene Loaded");
	}
}
