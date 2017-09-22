using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collide2 : MonoBehaviour {
	public GameObject cube;
	public static float score2;

	void Start()
	{
		score2 = 0;
	}
	// Update is called once per frame
	void FixedUpdate () {
		score2 += Time.deltaTime;
	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Cube")
		{
			SceneManager.LoadScene("GameOver2");
		}
		if (col.gameObject.name == "end") {
			SceneManager.LoadScene ("VICTORY2");
		}
	}
}
