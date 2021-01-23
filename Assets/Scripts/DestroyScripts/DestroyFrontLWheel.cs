using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFrontLWheel : MonoBehaviour
{

    [HideInInspector] public int WheelHp;
    [SerializeField] private WheelCollider wheelcol;



    // Start is called before the first frame update
    void Start()
    {
        WheelHp = 10;
    }

    private void OnCollisionEnter(Collision collision)
    {
        float collisionForce = collision.impulse.magnitude / Time.deltaTime;

        Debug.Log("Collide");

        if (collisionForce > 100.0f)
        {
            WheelHp = Mathf.Clamp(WheelHp, 1, 3);

            WheelHp--;

            Debug.Log("Wheel HP: " + WheelHp);

            if (WheelHp == 8)
            {
                Physics.IgnoreCollision(wheelcol, GetComponent<Collider>(), true);
                gameObject.SetActive(false);
            }

            if (WheelHp >= 1)
            {
                gameObject.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
