using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum NonIPickups 
{
    Gear,
    Fuel
}



public class NonIBoxPixkups : MonoBehaviour
{
    public NonIPickups iPickups;
    public int value = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            if (iPickups == NonIPickups.Gear)
            {
                other.GetComponent<Controller>().AddGear(value);
            }

            if (iPickups == NonIPickups.Fuel)
            {
                other.GetComponent<Controller>().AddFuel(value);
            }
        }
    }
}
