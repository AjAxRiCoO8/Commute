using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour {

    [SerializeField]
    GameObject followObject;

    [SerializeField]
    Vector3 vectorDistance = Vector3.zero;

    private void OnValidate()
    {
        transform.position = DetermineObjectPosition();
    }

	// Use this for initialization
	void Start () {
        transform.position = DetermineObjectPosition();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = DetermineObjectPosition();
	}

    Vector3 DetermineObjectPosition() {
        return followObject.transform.position + vectorDistance;
    }
}
