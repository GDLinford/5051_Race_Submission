using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : MonoBehaviour
{


	//  This is the car controller script from the main unity assets pack, figured we might be able to scavange bits from it



//	//privates for player control
//	[SerializeField]
//	private float acceleration = 100000f;
//	private Rigidbody rb;
//	[SerializeField]
//	public string prefix = "P1";
//	[SerializeField]
//	private float maxSpeed = 1f;
//	[SerializeField]
//	private float jumpForce = 100000f;
//	[SerializeField]
//	private GameObject jumpCheck;
//	private int groundLayer;

//	//privates for pickup
//	[SerializeField]
//	private Transform des;
//	private GameObject objectInRange = null;
//	private GameObject holding = null;
//	private int pickUpLayer;
//	private int wallLayer;
//	private FixedJoint joint = null;

//	void Start() {
//		rb = GetComponent<Rigidbody>(); //used later to make code more readable

//		//layer dependancies
//		groundLayer = LayerMask.NameToLayer("Ground");
//		pickUpLayer = LayerMask.NameToLayer("PickUp");
//		wallLayer = LayerMask.NameToLayer("Wall");

//	}

//	void FixedUpdate() {
//		float horizontal = acceleration * Input.GetAxis(prefix + "Horizontal"); //movement
//		float vertical = acceleration * Input.GetAxis(prefix + "Vertical"); //movement

//		float jump = jumpForce * Input.GetAxis(prefix + "Jump"); //jump
//		float interact = Input.GetAxis(prefix + "Interact"); //pickUp and drop

//		Vector3 force = new Vector3(horizontal, 0, vertical);

//		if (force.magnitude > 0) {
//			transform.LookAt(force);
//			rb.AddRelativeForce(Vector3.forward * force.magnitude * Time.fixedDeltaTime);
//		}

//		//Jump
//		bool grounded = Physics.Linecast(transform.position, jumpCheck.transform.position, 1 << groundLayer); //checks if player is grounded
//		if (grounded) {
//			rb.AddRelativeForce(Vector3.up * jump * Time.fixedDeltaTime);
//		}

//		//pick up
//		if (interact > 0 && !holding && objectInRange) {
//			PickUp(objectInRange);
//			holding = objectInRange;
//			objectInRange = null;
//		}

//		//drop
//		if (interact < 0 && holding) {
//			Drop(holding);
//			objectInRange = holding;
//			holding = null;
//		}
//	}

//	void LateUpdate() {
//		if (rb.velocity.magnitude > maxSpeed) {
//			rb.velocity = rb.velocity.normalized * maxSpeed; //stops objects moving faster than max speed
//		}
//	}

//	private void PickUp(GameObject gameObject) {
//#if false
//		gameObject.GetComponent<Rigidbody>().isKinematic = true; //makes picked up objects kinimatic to stop physics
//		gameObject.transform.position = des.position; //moves object to des(destination)
//		gameObject.transform.parent = des; //makes object chiled when being picked up
//#else
//		joint = this.gameObject.AddComponent<FixedJoint>();
//		joint.connectedBody = gameObject.GetComponent<Rigidbody>();

//		PickUp pickUp = gameObject.GetComponent<PickUp>();
//		pickUp.playerPrefix = prefix;
//#endif
//	}

//	private void Drop(GameObject gameObject) {
//#if false
//		gameObject.GetComponent<Rigidbody>().isKinematic = false; //makes object not kinematic
//		gameObject.transform.parent = null; //object is no longer has parant
//#else
//		Destroy(joint);
//		joint = null;

//		PickUp pickUp = gameObject.GetComponent<PickUp>();
//		pickUp.playerPrefix = null;
//#endif
//	}

//	private void OnTriggerEnter(Collider other) {
//		if (other.gameObject.layer == pickUpLayer) {
//			objectInRange = other.gameObject; //checks if object is in range
//		}
//	}

//	private void OnTriggerExit(Collider other) {

//		if (other.gameObject == objectInRange) {
//			objectInRange = null; //stops objects being flagged as in range after they leave trigger
//		}
//	}
}