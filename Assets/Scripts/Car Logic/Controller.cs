using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public KeyCode Right;
    public KeyCode Left;

    //private WheelHit FrontLWheelHit;

    private const string HORIZONTAL = "P2 Horizontal";
    private const string VERTICAL = "P2 Vertical";

    private float horizontalInput;
    private float verticalInput;
    private float Angle;
    private float currentBreakForce;
    private bool breaking;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteeringAngle;

    //[HideInInspector] public int frontLWheelHP;
    //[HideInInspector] public int frontRWheelHP;
    //[HideInInspector] public int RearLWheelHP;
    //[HideInInspector] public int RearRWheelHP;

    public int WheelsHP;
    public float mass = -0.9f;

    

    [SerializeField] private WheelCollider frontLeft;
    [SerializeField] private WheelCollider frontRight;
    [SerializeField] private WheelCollider RearLeft;
    [SerializeField] private WheelCollider RearRight;

    [SerializeField] private Transform frontLeftT;
    [SerializeField] private Transform frontRightT;
    [SerializeField] private Transform RearLeftT;
    [SerializeField] private Transform RearRightT;

    private void Start()
    {
        WheelsHP = 10;
        GetComponent<Rigidbody>().centerOfMass = new Vector3(0f, mass, 0f);
    }

    private void OnCollisionEnter(Collision collider)
    {
        float collisionForce = collider.impulse.magnitude / Time.deltaTime;

        Debug.Log("Collide");

        if (collisionForce > 1000.0f)
        {
            WheelsHP = Mathf.Clamp(WheelsHP, 1, 10);

            WheelsHP--;
            Debug.Log("Wheels HP: " + WheelsHP);

            if (WheelsHP == 8)
            {
                Physics.IgnoreCollision(RearLeft, GetComponent<Collider>(), true);
                RearLeft.gameObject.SetActive(false);
            }

            if (WheelsHP == 6)
            {
                Physics.IgnoreCollision(RearRight, GetComponent<Collider>(), true);
                RearRight.gameObject.SetActive(false);
            }

            if (WheelsHP == 4)
            {
                Physics.IgnoreCollision(frontLeft, GetComponent<Collider>(), true);
                frontLeft.gameObject.SetActive(false);
            }

            if (WheelsHP == 2)
            {
                Physics.IgnoreCollision(frontRight, GetComponent<Collider>(), true);
                frontRight.gameObject.SetActive(false);
            }

            if (WheelsHP > 4)
            {
                RearLeft.gameObject.SetActive(true);
            }

            if (WheelsHP > 6)
            {
                frontRight.gameObject.SetActive(true);
            }

            if (WheelsHP > 8)
            {
                frontLeft.gameObject.SetActive(true);
            }

            else if (WheelsHP == 0 && Input.GetKeyDown(KeyCode.Q))
            {
                WheelsHP += 10;

                RearLeft.gameObject.SetActive(true);
                RearRight.gameObject.SetActive(true);
                frontLeft.gameObject.SetActive(true);
                frontRight.gameObject.SetActive(true);

                //decrease score here
            }

        }

    }

    private void Update()
    {
        //GetComponent<Transform>().eulerAngles = new Vector3(0, 90, 0);
        GetInput();
        Motor();
        Steer();
        WheelVisuals();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(Right))
            transform.Rotate(0, 0, 30);

        if (Input.GetKeyDown(Left))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        breaking = Input.GetKey(KeyCode.Space);
    }

    private void Motor()
    {
        frontLeft.motorTorque = verticalInput * motorForce;
        frontRight.motorTorque = verticalInput * motorForce;
        RearLeft.motorTorque = verticalInput * motorForce;
        RearRight.motorTorque = verticalInput * motorForce;
        currentBreakForce = breaking ? breakForce : 0f;
        if (breaking)
        {
            BeginBreaking();
        }
    }

    private void Steer()
    {
        Angle = maxSteeringAngle * horizontalInput;
        frontLeft.steerAngle = Angle;
        frontRight.steerAngle = Angle;
    }

    private void WheelVisuals()
    {
        UpdateSingleWheel(frontLeft, frontLeftT);
        UpdateSingleWheel(frontRight, frontRightT);
        UpdateSingleWheel(RearLeft, RearLeftT);
        UpdateSingleWheel(RearRight, RearRightT);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform WTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        WTransform.rotation = rot;
        WTransform.position = pos;
    }

    private void BeginBreaking()
    {
        frontLeft.brakeTorque = currentBreakForce;
        frontRight.brakeTorque = currentBreakForce;
        RearLeft.brakeTorque = currentBreakForce;
        RearRight.brakeTorque = currentBreakForce;
    }


}
