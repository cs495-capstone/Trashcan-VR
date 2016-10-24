using UnityEngine;
using System.Collections;

public class Teleport_demo : MonoBehaviour {

	public GameObject indicator;

	// Use this for initialization
	void Start () {
		if (indicator == null) {
			indicator = GameObject.Find ("indicator");
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.T)) {
			foreach (var obj in GetComponentsInChildren<GameObject>
			this.transform.position = new Vector3(indicator.transform.position.x,this.transform.position.y,indicator.transform.position.z);
		}
	}
}
