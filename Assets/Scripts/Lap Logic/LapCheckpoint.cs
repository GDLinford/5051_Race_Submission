using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCheckpoint : MonoBehaviour
{
    public Text checkPoint;
    public int Number;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CarLap>())
        {
            CarLap car = other.GetComponent<CarLap>();
            Controller controller = other.GetComponent<Controller>();

            if (car.CheckpointNumber == Number + 1 || car.CheckpointNumber == Number - 1)
            {
                car.CheckpointNumber = Number;
                controller.WheelsHP += 1;
                Debug.Log("CarHpLApCheckpoint: " + controller.WheelsHP);
                car.score += 100;
            }
            checkPoint.text = "Checkpoint: " + Number;
        }
    }

}
