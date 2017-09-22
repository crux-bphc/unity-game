using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMov : MonoBehaviour {

	public GameObject Sphere;

	public Vector3 offset;

	void Start ()
	{
		offset = transform.position - Sphere.transform.position;
	}

	void Update ()
	{
		transform.position = Sphere.transform.position + offset;
	}
}