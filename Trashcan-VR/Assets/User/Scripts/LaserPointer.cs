using UnityEngine;
using System.Collections;

public class LaserPointer : MonoBehaviour {

	public GameObject indicator;

	private Vector3 hitPos;

	// Use this for initialization
	void Start () {
		if (indicator == null) {
			indicator = GameObject.CreatePrimitive (PrimitiveType.Cube);
			indicator.name = "indicator";
		}
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = new Ray (transform.position, transform.forward);
		if (Physics.Raycast (ray, out hit)) {
			if (hit.collider.name == "Terrain" && hitPos != hit.point) {
				hitPos = hit.point;
				indicator.transform.position = hitPos;
			}
		}
	}
}
