using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreenSwitch : MonoBehaviour
{
	[SerializeField]
	private Camera cam1, cam2;

	private bool isHorizontal;

	void Update() {
		if (Input.GetKeyDown(KeyCode.E)) {
			SwitchKey();
		}
	}

	private void SwitchKey() {
		isHorizontal = !isHorizontal;
		SwitchSplitAxis();
	}

	private void SwitchSplitAxis() {
		if (isHorizontal) {
			cam1.rect = new Rect(0f, .5f, 1f, .5f);
			cam2.rect = new Rect(0f, 0f, 1, .5f);
		} else {
			cam1.rect = new Rect(0f, 0f, .5f, 1f);
			cam2.rect = new Rect(.5f, 0f, .5f, 1f);
		}
	}
}
