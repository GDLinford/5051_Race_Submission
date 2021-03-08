using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public float motorForce;
    public float brakeForce;
    public float maxSteeringAngle;
    [HideInInspector] public float Angle;
    [HideInInspector] public float currentBreakForce;

    public int WheelsHP;
    [HideInInspector]
    public int wheelsCurHp;
    public float mass;

}
