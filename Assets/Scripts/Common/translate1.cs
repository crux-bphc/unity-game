using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate1 : MonoBehaviour {

	public int delay;
	public float speed;
	public static float level=15f;
	public static float trans = 15f;
	public static float timer;
	void Start()
	{
		delay = 1;
	}
	void FixedUpdate()
	{
		timer += Time.deltaTime;
		if (timer>delay)
		{
		float ver = Input.GetAxis ("Mouse Y");
			speed = ver * level;
		transform.Translate (new Vector3 (0, speed, trans)*Time.deltaTime);
			
		}
			


}
	public void AdjustTrans(float newS)
	{
		trans = newS;
	}
	public void AdjustMouse(float ms)
	{
		level = ms;
	}
}

			