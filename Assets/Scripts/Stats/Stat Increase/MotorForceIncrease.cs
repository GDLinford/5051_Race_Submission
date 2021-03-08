using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorForceIncrease : Stats
{

    public float increase;
    private void OnTriggerEnter(Collider other)
    {
        Controller controller = other.GetComponent<Controller>();
        controller.motorForce += increase;
        Destroy(gameObject);
    }

}
