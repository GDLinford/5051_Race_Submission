using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelBehaviour : MonoBehaviour
{
    [SerializeField]
    private WheelCollider[] wheelColliders;
    [SerializeField]
    private float maxAngle = 25;
    [SerializeField]
    private float maxTorque = 600;
    [SerializeField]
    private GameObject[] wheelMeshes;
	[SerializeField]
	private string prefix = "";

	void Start()
    {
#if false
        wheelColliders = GetComponentsInChildren<WheelCollider>();


        for (int i = 0; i < wheels.Length; ++i) {
            var wheel = wheels[i];

            if (wheelMesh != null) {
                var CarWheelMesh = GameObject.Instantiate(wheelMesh);
                CarWheelMesh.transform.parent = wheel.transform;
            }
        }
#endif
	}

	void Update()
    {
        float angle = maxAngle * Input.GetAxis(prefix +" "+ "Horizontal");
        float torque = maxTorque * Input.GetAxis(prefix +" "+ "Vertical");

        foreach (WheelCollider wheel in wheelColliders) {
            if (wheel.transform.localPosition.z > 0) {
                wheel.steerAngle = angle;
            }
            if (wheel.transform.localPosition.z > 0) {
                wheel.motorTorque = torque * 2;
            }
        }
    }

    void UpdateMeshesPositions() {
#if false
            foreach (WheelCollider wheel in whellColliders) {

                Vector3 wheelPosition = new Vector3(wheel.transform.position.x,
                                                    wheel.transform.position.y,
                                                    wheel.transform.position.z);

                Vector3 eulerWheelRotation = new Vector3(wheel.transform.eulerAngles.x,
                                                         wheel.transform.eulerAngles.y,
                                                         wheel.transform.eulerAngles.z);

                Transform carWheel = wheel.transform.GetChild(0); //assert all child objects are wheels
                carWheel.position = wheelPosition;
                transform.rotation = Quaternion.Euler(eulerWheelRotation);
                } 
#else
        for (int i = 0; i < wheelColliders.Length; i++) {
            Vector3 pos; 
            Quaternion quat;
            wheelColliders[i].GetWorldPose(out pos, out quat);
            wheelMeshes[i].transform.position = pos;
            wheelMeshes[i].transform.rotation = quat; 
            //Debug.Log(pos +" " + quat);
        }
#endif
    }

    void FixedUpdate() {
        UpdateMeshesPositions();
    }
}
