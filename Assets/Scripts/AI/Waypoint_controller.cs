using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint_controller : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>();
    private Transform target;

    private int TargetWaypointNumber = 0;
    private float minDistance = 0.1f;
    private int lastWaypointNum;

    [SerializeField]
    private float MoveSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        lastWaypointNum = waypoints.Count - 1;
        target = waypoints[TargetWaypointNumber];
    }

    // Update is called once per frame
    void Update()
    {
        float movementStep = MoveSpeed * Time.deltaTime;

        float distance = Vector3.Distance(transform.position, target.position);
        //Debug.Log("Distance: " + distance);
        CheckDistance(distance);

        transform.position = Vector3.MoveTowards(transform.position, target.position, movementStep);
        
    }

    void CheckDistance(float currentDistance)
    {
        if (currentDistance <= minDistance)
        {
            TargetWaypointNumber++;
            ChangeTarget();
        }
    }

    void ChangeTarget()
    {
        if (TargetWaypointNumber > lastWaypointNum)
        {
            TargetWaypointNumber = 0;
        }
        target = waypoints[TargetWaypointNumber];
    }
}
