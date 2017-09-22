using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collide4 : MonoBehaviour {
	public GameObject cube;
	public static float score4;

	void Start()
	{
		score4 = 0;
	}
	// Update is called once per frame
	void FixedUpdate () {
		score4 += Time.deltaTime;

	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Cube")
		{
			SceneManager.LoadScene("GameOver4");
		}
		if (col.gameObject.name == "end") {
			SceneManager.LoadScene ("VICTORY4");
		}
	}
}
