using UnityEngine;
using System.Collections;
/// <summary>
/// This class is used to change the position of an object based on the location of an indicator.
/// </summary>
public class Teleport_demo : MonoBehaviour {
	/// <summary>
	/// The indicator is an object that holds the location of where a user is looking
	/// </summary>
	public GameObject indicator;

	/// <summary>
	/// This is the keycode for the teleport key.
	/// </summary>
	public KeyCode code;

	/// <summary>
	/// This method finds the indicator object in the world and pulls it in.
	/// </summary>
	void Start () {
		if (indicator == null) {
			indicator = GameObject.Find ("indicator");
		}
		code = KeyCode.T;
	}

	/// <summary>
	/// This method checks to see if the teleport key is down, and if so the players position
	/// becomes the postiion of the indicator.
	/// </summary>
	void Update () {
		if (Input.GetKeyDown(code)) {
			this.transform.position = new Vector3(indicator.transform.position.x,this.transform.position.y,indicator.transform.position.z);
		}
	}
}
