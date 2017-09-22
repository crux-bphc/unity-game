using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class difficulty : MonoBehaviour {
	List<string> lev=new List<string>(){"Select Difficulty","Very Easy", "Easy","Moderate", "Hard", "Very Hard"};
	public Dropdown dl;

	// Use this for initialization
	void Start () {
		Addlevel ();
		
	}
	void Addlevel()
	{
		dl.AddOptions (lev);
	}
	public void chdl(int index)
	{
		if (index == 1)
			translate1.trans = 5;
		if (index == 2)
			translate1.trans = 10;
		if (index == 3)
			translate1.trans = 15;
		if (index == 4)
			translate1.trans = 20;
		if (index == 5)
			translate1.trans = 25;
	}
	
	// Update is called once per frame

}
