using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildFinish : MonoBehaviour
{
	public CarComplete cC;

	public void ChangeScene() {
		if (cC.carComplete) {
			LoadNextScene();
		}
	}

	public void LoadNextScene() {
		SceneManager.LoadScene(SceneManager.sceneCount + 0);
		Debug.Log("Scene Loaded");
	}
}
