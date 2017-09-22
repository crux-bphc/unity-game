using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sc3 : MonoBehaviour {
	public Text sco;
	int lm;


	// Use this for initialization
	void Start () {




	}

	// Update is called once per frame
	void Update () {
		lm =Mathf.RoundToInt((Collide3.score3));
		sco.text = " Score : " + lm.ToString ();
		h3.high (lm);
	}

}