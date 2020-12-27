using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarHP : MonoBehaviour
{

	private int carHP;

	public Text hitpoints;

	private void Start() {
		carHP = 100;
		hitpoints = GetComponent<Text>();
	}

	private void Update() {
		hitpoints.text = carHP.ToString();
	}

	private void OnCollisionEnter(Collision collision) {
		float collisionForce = collision.impulse.magnitude / Time.fixedDeltaTime;
		Debug.Log("colide");
		

		//if (collisionForce < 2.0F) {

		//} else 
		if (collisionForce > 0.1F) {
			carHP = carHP--;
			
			if (carHP < 1) {
				Debug.Log("Ofuckwedead");
				
			}
		} else {
			Debug.Log("NUTHIN");
		}
	}
}
