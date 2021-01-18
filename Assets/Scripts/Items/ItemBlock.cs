using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlock : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car")
        {
            if (other.GetComponent<Itemuse>().ItemHeld == -1 && other.GetComponent<Itemuse>().CanPickup)
            {
                other.GetComponent<Itemuse>().PickupBegin();
                Destroy(this.gameObject);
            }
        }
    }


}
