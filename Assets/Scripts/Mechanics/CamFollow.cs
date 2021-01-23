using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
	// the target to follow
	[SerializeField]
	private Transform follow;	
	[SerializeField]
	private Transform lookAt;

	// speed between 0 - no camera movement and 1 - follow immediately
	[SerializeField]
	private float smoothSpeed = 0.01f;

	void LateUpdate() {
		transform.LookAt(lookAt);

		// move towards the desired position using linear interpolation (lerp)
		transform.position = Vector3.Lerp(transform.position, follow.position,
			smoothSpeed);
	}
}
