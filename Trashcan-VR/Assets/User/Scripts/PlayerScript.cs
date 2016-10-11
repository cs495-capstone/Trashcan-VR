using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PlayerScript : MonoBehaviour
{
	public GameObject prefab;

    private SteamVR_TrackedObject trackedObj;
    private FixedJoint joint;
	private bool connected;
	private GameObject go;
	private Vector3 oldPos;


    void Start()
    {
		connected = false;
        trackedObj = GetComponent<SteamVR_TrackedObject>();
		oldPos = transform.position;
    }

    void Update()
    {
        var device = SteamVR_Controller.Input((int)trackedObj.index);

		SteamVR_TrackedController controller = GetComponent<SteamVR_TrackedController>();

		if (!connected && device.GetTouchDown (SteamVR_Controller.ButtonMask.Trigger)) {
			go = GameObject.Instantiate (prefab);
			go.transform.position = trackedObj.transform.position;

			var vel = transform.position - oldPos;
			go.GetComponent<Rigidbody> ().velocity = (vel.magnitude + 200) * transform.forward;
			connected = true;
		} else if (connected) {
			go.transform.position = trackedObj.transform.position;
		}

		if (!device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)) {
			connected = false;
		}
    }
}