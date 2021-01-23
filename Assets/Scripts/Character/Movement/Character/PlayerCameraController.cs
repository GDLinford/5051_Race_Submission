using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{

	[SerializeField]
	private float lookSensitivity = 2;
	[SerializeField]
	private float smoothing = 1;

	private GameObject player;
	private Vector2 smoothedVelocity;
	private Vector2 currentLookingPos;
	// Start is called before the first frame update
	void Start() {
		player = transform.parent.gameObject;
	}

	// Update is called once per frame
	void Update() {
		RotateCamera();
	}

	private void RotateCamera(){
		// Create the vector 2 we are going to use to move the camera, plugging mouse X/Y for input and store it
		Vector2 inputValues = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
		// Add our smoothing and sensitivity to our stored Vector2's scale taken from our mouse input
		inputValues = Vector2.Scale(inputValues, new Vector2(lookSensitivity * smoothing, lookSensitivity * smoothing));
		// Use Lerp to smooth out the end of our movement on the X/Y and give us our actual camera movement 
		smoothedVelocity.x = Mathf.Lerp(smoothedVelocity.x, inputValues.x, 1f / smoothing);
		smoothedVelocity.y = Mathf.Lerp(smoothedVelocity.y, inputValues.y, 1f / smoothing);
		// Set our actual looking position using our smoothed out velocity
		currentLookingPos += smoothedVelocity;
		// Use Quaternion to rotate our camera
		transform.localRotation = Quaternion.AngleAxis(-currentLookingPos.y, Vector3.right);
		player.transform.localRotation = Quaternion.AngleAxis(currentLookingPos.x, player.transform.up);
	}
}
