using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDamage : MonoBehaviour
{
    private int carHP;

    private void Start()
    {
        carHP = 3;
    }

    private void OnCollisionEnter(Collision collision)
    {
        float collisionForce = collision.impulse.magnitude / Time.deltaTime;
        Debug.Log("Collide");
        if (collisionForce > 2.0f)
        {

            carHP--;
            Debug.Log("CarHp: " + carHP);
            if (carHP < 0)
            {
                Debug.Log("oFuckweDead");
            }
            else
            {
                Debug.Log("oFuckWeDead2");
            }
        }
    }

}
