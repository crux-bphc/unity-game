using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour {
	public Text sco;
	int lm;


	// Use this for initialization
	void Start () {
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		lm =Mathf.RoundToInt((Collide1.score1));
		sco.text = " Score : " + lm.ToString ();
		highsc.high (lm);
	}

}
