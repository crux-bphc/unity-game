using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowed : MonoBehaviour {

	// Use this for initialization
	public void iswin(bool wind)
	{
		Screen.fullScreen = !Screen.fullScreen;
	}
}

