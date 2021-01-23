using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    private float sTime;
    // Start is called before the first frame update
    void Start()
    {
        sTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //t is how much time has passed since the timer started.
        float t = Time.time - sTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timer.text = minutes + ":" + seconds;
    }
}
