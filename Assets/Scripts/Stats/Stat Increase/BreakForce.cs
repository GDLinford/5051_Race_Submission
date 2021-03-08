using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakForce : Stats
{
    public float increase;
    private void OnTriggerEnter(Collider other)
    {
        Controller controller = other.GetComponent<Controller>();
        controller.currentBreakForce += increase;
        Destroy(gameObject);
    }
}
