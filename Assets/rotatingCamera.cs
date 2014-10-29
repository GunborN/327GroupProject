using UnityEngine;
using System.Collections;

public class rotatingCamera : MonoBehaviour {
	public int speed;
	public GameObject rotatingPoint;
	// Use this for initialization
	void Start () {
		gameObject.transform.LookAt (rotatingPoint.transform);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.LookAt (rotatingPoint.transform);
		//transform.Translate(Vector3.right * Time.deltaTime);
		transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
	}
}
