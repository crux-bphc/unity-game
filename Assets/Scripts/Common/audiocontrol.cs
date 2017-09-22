using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class audiocontrol : MonoBehaviour {

	static bool AudioBegin = false; 

	void Awake()
	{
		AudioSource audio = GetComponent<AudioSource> ();
		if (!AudioBegin) {
			DontDestroyOnLoad (gameObject);
			audio.Play ();
			AudioBegin = true;
		} 
	}
	void Update()
	{
		AudioSource audio = GetComponent<AudioSource> ();
		if ((Application.loadedLevelName == "Level 1")||(Application.loadedLevelName == "Level 2")||(Application.loadedLevelName == "Level 3")||(Application.loadedLevelName=="Level 4")) {
			audio.Stop ();
			AudioBegin = false;

		}
	}
}
