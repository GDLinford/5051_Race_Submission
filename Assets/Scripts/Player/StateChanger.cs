using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChanger : MonoBehaviour
{
	public GameObject car;

	public GameObject character;

	public GameObject character2;

	public Camera camera1;

	public Camera camera2;

	public Camera camera3;

	//public Camera[] cameras;
	//private int currentCameraIndex;	

	private void Update() {
		//Changer();
		CallChanger();
	}

	public void Changer () {	 
			camera1.gameObject.SetActive(false);
			camera2.gameObject.SetActive(true);
			car.SetActive(true);
			character.SetActive(false);
			//StateChange();	
	}


	//Needs to be removed and added to changer somehow, either using bools or an array system would probably be most efficient
	public void Changer2() {
		//camera2.gameObject.SetActive(false);
		//camera3.gameObject.SetActive(true);
		//car.SetActive(false);
		//character2.SetActive(true);
		//StateChange();	
	}


	private void CallChanger() {
		if(Input.GetKeyUp(KeyCode.N)){
			Changer();
		}
		if (Input.GetKeyDown(KeyCode.P)) {
			Changer2();
		}
	}

	//private void StateChange() {
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

	//private void Start() {
	//	//Turn all cameras off, except the first default one
	//	for (int i = 1; i < cameras.Length; i++) {
	//		cameras[i].gameObject.SetActive(false);
	//	}

	//	//If any cameras were added to the controller, enable the first one
	//	if (cameras.Length > 0) {
	//		cameras[0].gameObject.SetActive(true);
	//		Debug.Log("Camera with name: " + ", is now enabled");
	//	}
	//}
}
