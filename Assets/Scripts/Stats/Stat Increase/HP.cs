using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : Stats
{
    //probably wouldnt ever go above 10 unless we wanted to put something really out of the way

    public int increase;
    private void OnTriggerEnter(Collider other)
    {
        Controller controller = other.GetComponent<Controller>();
        controller.WheelsHP += increase;
        Destroy(gameObject);
    }
}
