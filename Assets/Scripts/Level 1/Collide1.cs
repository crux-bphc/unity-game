using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collide1 : MonoBehaviour {
	public GameObject cube;
	public static float score1=0;

	void Start()
	{
		score1 = 0;

	

	}
	void FixedUpdate () {
		
		score1 +=Time.deltaTime;
	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Cube")
		{
			SceneManager.LoadScene("GameOver1");
				

		}
		if (col.gameObject.name == "end") {
			SceneManager.LoadScene ("VICTORY1");
		}
	}
		
}


