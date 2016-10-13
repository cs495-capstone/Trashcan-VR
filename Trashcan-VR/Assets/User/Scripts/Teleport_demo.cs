using UnityEngine;
using System.Collections;

public class Teleport_demo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		var x_val = this.transform.position.x;
		var y_val = this.transform.position.y;
		var z_val = this.transform.position.z;
		if (Input.GetKeyDown (KeyCode.W)) {
			z_val += 10;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			z_val -= 10;
		} else if (Input.GetKeyDown (KeyCode.A)) {
			x_val -= 10;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			x_val += 10;
		}
		this.transform.position = new Vector3 (x_val, y_val, z_val);
	}
}
