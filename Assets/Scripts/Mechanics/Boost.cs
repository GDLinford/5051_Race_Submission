using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    [SerializeField]
    private float boost = 9999f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            Debug.Log("Boosting");
            Vector3 push = new Vector3(0, boost, 0f);
            other.gameObject.GetComponent<Rigidbody>().AddForce(push);
        }
    }

}
