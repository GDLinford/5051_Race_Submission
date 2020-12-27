using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
	//Toggle off the current model

	private GameObject[] characterList;
	private int index;

    void Start()
    {
		//
		index = PlayerPrefs.GetInt("CharacterSelected");

		characterList = new GameObject[transform.childCount];
		// Fill array with models
		for (int i = 0; i < transform.childCount; i++) {
			characterList[i] = transform.GetChild(i).gameObject;
		}
		// Toggle off renderer
		foreach (GameObject go in characterList)
			go.SetActive(false);
		// Toggle on selected character
		if (characterList[index])
			characterList[index].SetActive(true);
    }

	public void ToggleLeft() {
		characterList[index].SetActive(false);

		index--;
		if (index < 0)
			index = characterList.Length - 1;

		characterList[index].SetActive(true);
	}

	public void ToggleRight() {
		characterList[index].SetActive(false);

		index++;
		if (index == characterList.Length)
			index = 0;
		//toggle on the new model
		characterList[index].SetActive(true);
	}

	public void ConfirmButton() {
		PlayerPrefs.SetInt("CharacterSelected", index);
		SceneManager.LoadScene(SceneManager.sceneCount + 1);
	}

	
}
