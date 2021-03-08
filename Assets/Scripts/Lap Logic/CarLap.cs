using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarLap : MonoBehaviour
{
    [HideInInspector]
    public int lapNumber;
    [HideInInspector]
    public int CheckpointNumber;
    [HideInInspector]
    public int score;
    public Text LapNumber;
    public Text Score;

	public StateChanger stateChanger;

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
			// Hijacked for demo, should take us to win page but takes us to menu
			SceneManager.LoadScene(SceneManager.sceneCount + -1);
			//Hijacked the hijack for demo
			//stateChanger.Changer2();
			Debug.Log("you win");
        }

        LapNumber.text = "Lap: " + lapNumber;
        Score.text = "Score: " + score;
    }
}
