using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameScript : MonoBehaviour
{
    
	void OnMouseOver() {
		if (Input.GetMouseButtonUp(0)) {
			Application.Quit();
			Debug.Log("We quit");
		}
	}


	public void QuitGame() {
		Application.Quit();
		Debug.Log("We quit");
	}
}
