using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) {
			MainMenu();
		}
		if (Input.GetKey(KeyCode.Tab)) {
			RestartLevel();
		}

	}

	private void MainMenu() {
		SceneManager.LoadScene(SceneManager.sceneCount - 1);
		Debug.Log("Scene Loaded");
	}

	private void RestartLevel() {
		SceneManager.LoadScene(SceneManager.sceneCount + 1);
		Debug.Log("Scene Loaded");
	}


}
