using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarComplete : MonoBehaviour
{

	public GameObject carEngine;

	public GameObject carWheel, carWheel2, carWheel3, carWheel4;

	public GameObject carGear;

	public GameObject carSteeringWheel;

	public StateChanger stateChange;

	public bool carInRange;

	public bool carComplete;

	public bool hasEngine;

	public bool hasGear;

	public bool hasSteeringWheel;

	public bool hasWheel;

	public bool steeringWheelFitted;

	public bool engineFitted;

	public bool gearFitted;

	public bool wheelFitted;

	public void Update() {
		//ChangeScene();
		if (engineFitted && gearFitted && steeringWheelFitted && wheelFitted) {
			//carComplete = true;
			//Debug.Log("We dun built a car son");
			stateChange.Changer();
		}
	}

	private void Start() {
		carComplete = false;
		hasEngine = false;
		hasGear = false;
		hasSteeringWheel = false;
		hasWheel = false;
		wheelFitted = false;
		gearFitted = false;
		engineFitted = false;
		steeringWheelFitted = false;
		carInRange = false;
	}

	public void LoadNextScene() {
		//SceneManager.LoadScene(SceneManager.sceneCount + 3);
		//Debug.Log("Scene Loaded");
	}


	//Can be used for a final car build to change scene
	//public void ChangeScene() {
	//	if (carComplete) {		
	//		LoadNextScene();
	//	}
	//}

	private void OnTriggerEnter(Collider other) {
		carInRange = true;
	}

	private void OnTriggerExit(Collider other) {
		carInRange = false;
	}


	private void CarIsComplete() {
		
	}
}
