using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum NonIPickups 
{
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
            if (iPickups == NonIPickups.Fuel)
            {
                other.GetComponent<Controller>().AddFuel(value);
                Destroy(this.gameObject);
            }
        }
    }
}
