using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brightness : MonoBehaviour
{

	public float rbgValue;

	public float level;

	private void Update() {

	}

	public void SetBrightness(float sliderValue) {
		rbgValue = sliderValue;
		RenderSettings.ambientLight = new Color(sliderValue, sliderValue, sliderValue, 1);
	}
}
