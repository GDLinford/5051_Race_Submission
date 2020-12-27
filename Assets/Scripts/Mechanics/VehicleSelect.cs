using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VehicleSelect : MonoBehaviour
{
	private GameObject[] vehicleList;
	private int index;

	void Start() {
		//
		index = PlayerPrefs.GetInt("VehicleSelected");

		vehicleList = new GameObject[transform.childCount];
		// Fill array with models
		for (int i = 0; i < transform.childCount; i++) {
			vehicleList[i] = transform.GetChild(i).gameObject;
		}
		// Toggle off renderer
		foreach (GameObject go in vehicleList)
			go.SetActive(false);
		// Toggle on selected character
		if (vehicleList[index])
			vehicleList[index].SetActive(true);
	}

	public void ToggleLeft() {
		vehicleList[index].SetActive(false);

		index--;
		if (index < 0)
			index = vehicleList.Length - 1;

		vehicleList[index].SetActive(true);
	}

	public void ToggleRight() {
		vehicleList[index].SetActive(false);

		index++;
		if (index == vehicleList.Length)
			index = 0;
		//toggle on the new model
		vehicleList[index].SetActive(true);
	}

	public void ConfirmButton() {
		SceneManager.LoadScene(SceneManager.sceneCount + 0);
		SceneManager.LoadScene(3);
	}
}
