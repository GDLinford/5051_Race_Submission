using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    [SerializeField]
    float boost = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            Vector3 push = new Vector3(0, boost, 0f);
            other.gameObject.GetComponent<Rigidbody>().AddForce(push);
        }
    }

}
