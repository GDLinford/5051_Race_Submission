using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateControl : MonoBehaviour
{
	public bool isPlayer;

	public GameObject character;

	public GameObject car;

	public Camera[] cameras;
	private int currentCameraIndex;
	public bool optionsMenuOn;

	// Use this for initialization
	void Start() {
		//currentCameraIndex = 0;

		isPlayer = true;

		//Turn all cameras off, except the first default one
		for (int i = 1; i < cameras.Length; i++) {
			cameras[i].gameObject.SetActive(false);
		}

		//If any cameras were added to the controller, enable the first one
		if (cameras.Length > 0) {
			cameras[0].gameObject.SetActive(true);
			Debug.Log("Camera with name: " + ", is now enabled");
		}
	}

	// Update is called once per frame
	//void Update() {
	//	//If the c button is pressed, switch to the next camera
	//	//Set the camera at the current index to inactive, and set the next one in the array to active
	//	//When we reach the end of the camera array, move back to the beginning or the array.
	//	if (!isPlayer) {
	//		StateSwitch();
	//		GameobjectActivation();
	//	}
	//}

	//void GameobjectActivation() {
	//	if (isPlayer) {
	//		character.SetActive(false);
	//		car.SetActive(true);
	//	}
	//	if (!isPlayer) {
	//		character.SetActive(true);
	//		car.SetActive(false);
	//	}
	//}

	//private void StateSwitch() {
	//	if (currentCameraIndex < cameras.Length) {
	//		cameras[currentCameraIndex - 1].gameObject.SetActive(false);
	//		cameras[currentCameraIndex].gameObject.SetActive(true);
	//		Debug.Log("Camera with name: " + 0 + " is now enabled");
	//	} else {
	//		cameras[currentCameraIndex - 1].gameObject.SetActive(false);
	//		currentCameraIndex = 0;
	//		cameras[currentCameraIndex].gameObject.SetActive(true);
	//		Debug.Log("Camera with name: " + 1 + " is now enabled");
	//	}
	//}
}


