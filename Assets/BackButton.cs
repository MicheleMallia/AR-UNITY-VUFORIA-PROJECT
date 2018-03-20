using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android)
		{	
			//quit from application if user press back button
			if (Input.GetKeyUp(KeyCode.Escape))
			{
				Application.Quit();
				return;
			}
		}
	}
}
