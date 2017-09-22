using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collide3 : MonoBehaviour {
	public GameObject cube;
	public static float score3;

	void Start()
	{
		score3 = 0;
	}
	// Update is called once per frame
	void FixedUpdate () {
		score3 += Time.deltaTime;

	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Cube")
		{
			SceneManager.LoadScene("GameOver3");
		}
		if (col.gameObject.name == "end") {
			SceneManager.LoadScene ("VICTORY3");
		}
	}
}
