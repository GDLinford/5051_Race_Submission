using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : CarComplete
{

	//public string playerPrefix = null;
	private bool isClose;

	public Transform objectDestination;

	public GameObject objectInHand;

	public CarComplete cC;

	void Start() {
		isClose = false;
	}

	public void LateUpdate() {
		
	}

	private void OnTriggerEnter(Collider other) {
		isClose = true;
	}

	private void OnTriggerExit(Collider other) {
		isClose = false;
	}

	void OnMouseDown() {
		if (isClose) {
			GetComponent<Rigidbody>().isKinematic = true;
			GetComponent<Rigidbody>().useGravity = false;
			this.transform.position = objectDestination.position;
			this.transform.parent = GameObject.Find("Hand").transform;
			objectInHand = this.gameObject;
			IdentifyItem();
			
		}
	}

	void OnMouseUp() {
		this.transform.parent = null;
		GetComponent<Rigidbody>().useGravity = true;
		GetComponent<Rigidbody>().isKinematic = false;
		cC.hasEngine = false;
		cC.hasSteeringWheel = false;
		cC.hasGear = false;
		cC.hasWheel = false;
		if (objectInHand.gameObject.CompareTag("Engine") && cC.carInRange) {
			cC.engineFitted = true;
			cC.carEngine.SetActive(true);
			Destroy(gameObject);
		}
	

		
		if (objectInHand.gameObject.CompareTag("SteeringWheel" ) && cC.carInRange) {
			cC.steeringWheelFitted = true;
			cC.carSteeringWheel.SetActive(true);
			Destroy(gameObject);
		}
		if (objectInHand.gameObject.CompareTag("Gear") && cC.carInRange) {
			cC.gearFitted = true;
			cC.carGear.SetActive(true);
			Destroy(gameObject);
		}
		if (objectInHand.gameObject.CompareTag("Wheel") && cC.carInRange) {
			cC.wheelFitted = true;
			cC.carWheel.SetActive(true);
			cC.carWheel2.SetActive(true);
			cC.carWheel3.SetActive(true);
			cC.carWheel4.SetActive(true);
			Destroy(gameObject);
		}
		
	}

	public void IdentifyItem() {
		if (objectInHand.gameObject.CompareTag("Engine")) {
			cC.hasEngine = true;
			Debug.Log("we found Engine");
		}
		if (objectInHand.gameObject.CompareTag("SteeringWheel")) {
			cC.hasSteeringWheel = true;
			Debug.Log("we found SWheel");
		}
		if (objectInHand.gameObject.CompareTag("Wheel")) {
			cC.hasWheel = true;
			Debug.Log("we found Wheel");
		}
		if (objectInHand.gameObject.CompareTag("Gear")) {
			cC.hasGear = true;
			Debug.Log("we found Gear");
		}
	}
}
