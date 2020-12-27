using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{

	float currentTime = 0f;
	float startingTime = 60f;
	public Text timeDisplay;

	private void Start() {
		timeDisplay = GetComponent<Text>();
		currentTime = startingTime;
	}

	private void Update() {
		currentTime -= 1 * Time.deltaTime;
		timeDisplay.text = currentTime.ToString();
	}

}

