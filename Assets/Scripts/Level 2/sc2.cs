using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sc2 : MonoBehaviour {
	public Text sco;
	int lm;


	// Use this for initialization
	void Start () {




	}

	// Update is called once per frame
	void Update () {
		lm =Mathf.RoundToInt((Collide2.score2));
		sco.text = " Score : " + lm.ToString ();
		h2.high (lm);
	}

}