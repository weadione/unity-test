using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class ViveController : MonoBehaviour {
    private SteamVR_TrackedObject trackedObject;
    private GameObject paper;
    private SteamVR_Controller.Device controller
    {
        get
        {
            return SteamVR_Controller.Input((int)trackedObject.index);
        }
    }
	// Use this for initialization
	void Start () {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
        paper = GameObject.Find("New Sprite");
	}
	
	// Update is called once per frame
	void Update () {
	    if(controller==null)
        {
            Debug.Log("no controller");
            return;
        }

        if(controller.GetHairTriggerDown())
        {
            Instantiate("New Sprite");
        }
	}
}
