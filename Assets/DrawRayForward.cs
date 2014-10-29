using UnityEngine;
using System.Collections;

public class DrawRayForward : MonoBehaviour 
{
	public bool Enabled;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Enabled == true) {
						Debug.DrawRay (transform.position, transform.forward * 5.0f, Color.red, 1.0f);
				}
	}
}
