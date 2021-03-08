using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField]
    private GameObject TeleporterExit;

    void OnTriggerEnter(Collider Boulder)
    {
        if (Boulder.gameObject.tag != "Boulder")
        {
            return;
        }

        Boulder.gameObject.transform.position = TeleporterExit.transform.position;
    }

}
