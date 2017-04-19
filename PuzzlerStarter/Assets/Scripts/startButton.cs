using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour {

	public Camera mainCam;
	public GameObject waypoint;

	public void OnClicked()
	{
		Debug.Log ("Clicked the button");
		mainCam.transform.position = waypoint.transform.position;
	}

	public void OnHover()
	{
		Debug.Log ("Hovering oVer");
	}
}
