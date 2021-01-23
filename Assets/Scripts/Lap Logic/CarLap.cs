using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLap : MonoBehaviour
{
    [HideInInspector]
    public int lapNumber;
    [HideInInspector]
    public int CheckpointNumber;
    [HideInInspector]
    public int score;

    // Start is called before the first frame update
    private void Start()
    {
        lapNumber = 1;
        CheckpointNumber = 0;
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lapNumber == 2)
        {
            Debug.Log("you win");
        }
    }
}
