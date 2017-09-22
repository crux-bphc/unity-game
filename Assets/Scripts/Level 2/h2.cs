using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class h2 : MonoBehaviour {
	public Text hst;
	public static int highscore;
	public static int temp;
	void Awake()
	{

	}
	// Use this for initialization
	void Start () {

		highscore = Mathf.Max (temp,highscore );
		hst.text = "High score : " + highscore.ToString();
	}

	// Update is called once per frame
	void Update () {

	}
	public static void high(int t)
	{
		temp = t;
	}

}
