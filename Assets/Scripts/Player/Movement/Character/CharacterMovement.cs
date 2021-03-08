using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	// serialized so we can adjust in editor but they remain private to avoid cross class dodgery
	[SerializeField]
	private float speed = 3f;
	[SerializeField]
	private float jumpForce = 4f;
	[SerializeField]
	private float jumpRaycastDistance = 1.3f;

	public PlayerStateControl playerState;

	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	private void Update() {
		Jump();
	}

	private void FixedUpdate() {
		//if (playerState.isPlayer) {
			
		//}
		Move();
	}

	private void Move() {
		// Get Input from Horizontal/Vertical
		float hAxis = Input.GetAxisRaw("Horizontal");
		float vAxis = Input.GetAxisRaw("Vertical");
		// Calculate how far we want to move in certain direction
		Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.fixedDeltaTime;
		// Calculate our new position
		Vector3 newPosition = rb.position + rb.transform.TransformDirection(movement);
		// Move to new position
		rb.MovePosition(newPosition);
	}

	private void Jump() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			if (IsGrounded()) {
				rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
			}
		}
	}

	private bool IsGrounded() {
		Debug.DrawRay(transform.position, Vector3.down * jumpRaycastDistance, Color.blue);
		return (Physics.Raycast(transform.position, Vector3.down, jumpRaycastDistance));
	}
}

//	public float mouseSensitivity = 100f;
//// Sets the gameObject (player) the camera is going to be moving around
//public Transform playerBody;

//float xRotation = 0f;

//void Start() {
//	playerBody = Transform.GetComponent<Transform>
//	}

//void FixedUpdate() {
//	//Sets an input coming from the mouse on the X/Y
//	float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
//	float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

//	xRotation -= mouseY;
//	xRotation = Mathf.Clamp(xRotation, -90f, 90f);

//	transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

//	playerBody.Rotate(Vector3.up * mouseX);
