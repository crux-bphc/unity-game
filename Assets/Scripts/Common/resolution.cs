using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resolution : MonoBehaviour {
	public Dropdown drop;
	List<string> reso = new List<string>(){"Select Resolution","1366x768", "1024x720", "800x600"};

	// Use this for initialization
	void Start () {
		pop ();
		
	}
	public void reschange(int index)
	{
		if (index == 1)
			Screen.SetResolution (1366, 768, true);
		if (index == 2)
			Screen.SetResolution (1280, 720, true);
		if (index == 3)
			Screen.SetResolution (800, 600, true);
		
	}
	void pop()
	{
		drop.AddOptions (reso);
	}

	
	// Update is called once per frame
}
