using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowFinger : MonoBehaviour {
    
    [SerializeField]
    ScreenSide fingerPosition;

    Image fingerTracker;

	// Use this for initialization
	void Start () {
        fingerTracker = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

        bool fingerFound = false;
        
        foreach (Touch touch in Input.touches)
        {
            if (TouchControls.HoldOnSide(fingerPosition, touch)) {
                fingerFound = true;
                transform.position = touch.position;
                break;
            }
        }

        fingerTracker.enabled = fingerFound;

        // Do more stuff if neccesarry
    }
}
