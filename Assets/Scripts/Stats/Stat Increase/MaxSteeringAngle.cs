using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSteeringAngle : Stats
{
    //this one could probably get really messed up if we took it high, for now I say just keep it around an increase of 10, maybe 20 but just be careful

    public float increase;
    private void OnTriggerEnter(Collider other)
    {
        Controller controller = other.GetComponent<Controller>();
        controller.maxSteeringAngle += increase;
        Destroy(gameObject);
    }
}
