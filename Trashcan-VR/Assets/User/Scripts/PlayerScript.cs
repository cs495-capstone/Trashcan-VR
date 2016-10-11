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


    void Start()
    {
		connected = false;
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    void Update()
    {
        var device = SteamVR_Controller.Input((int)trackedObj.index);

		if (!connected && device.GetTouchDown (SteamVR_Controller.ButtonMask.Trigger)) {
			go = GameObject.Instantiate (prefab);
			go.transform.position = trackedObj.transform.position;
			connected = true;
		} else if (connected) {
			go.transform.position = trackedObj.transform.position;
		}

		if (!device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)) {
			connected = false;
		}
    }
}