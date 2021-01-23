using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVehicle : MonoBehaviour
{


	public float motorForce, steerForce, brakeForce;
	public WheelCollider FR_L_Wheel, FR_R_Wheel, RE_L_Wheel, RE_R_Wheel;

	// Update is called once per frame
	void Update() {
		float v = Input.GetAxis("Horizontal") * motorForce;
		float h = Input.GetAxis("Horizontal") * steerForce;

		RE_R_Wheel.motorTorque = v;
		RE_L_Wheel.motorTorque = v;

		FR_L_Wheel.steerAngle = h;
		FR_R_Wheel.steerAngle = h;

		if (Input.GetKey(KeyCode.Space)) {
			RE_L_Wheel.brakeTorque = brakeForce;
			RE_R_Wheel.brakeTorque = brakeForce;
		}
		if (Input.GetKeyUp(KeyCode.Space)) {
			RE_L_Wheel.brakeTorque = 0;
			RE_R_Wheel.brakeTorque = 0;
		}
		if (Input.GetAxis("Vertical") == 0) {
			RE_L_Wheel.brakeTorque = brakeForce;
			RE_R_Wheel.brakeTorque = brakeForce;
		} else {
			RE_L_Wheel.brakeTorque = 0;
			RE_R_Wheel.brakeTorque = 0;
		}
	}
}
