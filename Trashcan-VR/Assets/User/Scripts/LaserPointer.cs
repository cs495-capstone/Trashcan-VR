using UnityEngine;
using System.Collections;

/// <summary>
/// This script shows the user where they are looking using a game object. It kind
/// of acts like a laser pointer because the object is placed directly where the 
/// camera that this script is attached to is looking.
/// </summary>
public class LaserPointer : MonoBehaviour {

	/// <summary>
	/// This is the game object used to show the user where they are looking/where
	/// they will teleport.
	/// </summary>
	public GameObject indicator;

	/// <summary>
	/// This is where rays casted from the camera's position intersect with the world.
	/// This is the vector we set to be the indicator's position.
	/// </summary>
	private Vector3 hitPos;

	/// <summary>
	/// This method is called when the game is initially run. If the indicator
	/// is not set from the Unity panel, then it will automatically create a 
	/// cube to use as the indicator.
	/// </summary>
	void Start () {
		if (indicator == null) {
			indicator = GameObject.CreatePrimitive (PrimitiveType.Cube);
			indicator.name = "indicator";
		}
	}

	/// <summary>
	/// This method gets called once per frame and just updates the location of the indicator
	/// object so that the user can see where they are looking/where they will be able to 
	/// teleport to.
	/// </summary>
	void Update () {
		RaycastHit hit;

		// Shoot a ray out from the camera using its angle and position
		Ray ray = new Ray (transform.position, transform.forward);

		// See if the ray intersects with the world
		if (Physics.Raycast (ray, out hit)) {
			// Only set the indicator if the ray hits terrain. This prevents teleporting into the sky
			if (hit.collider.name == "Terrain" && hitPos != hit.point) {
				hitPos = hit.point;
				indicator.transform.position = hitPos;
			}
		}
	}
}
