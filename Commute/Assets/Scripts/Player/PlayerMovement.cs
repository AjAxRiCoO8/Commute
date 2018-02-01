using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AccelerometerInput))]
public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    [Range(0.1f, 10f)]
    float speedPerSecond = 1f;

    AccelerometerInput accInput;

	// Use this for initialization
	void Start () {
        accInput = GetComponent<AccelerometerInput>();
	}
	
	// Update is called once per frame
	void Update () {
        // Translate the gameObject according to the devices orientation and the speed given.
        transform.Translate(accInput.GetXMovement(), 0, speedPerSecond * Time.deltaTime);
	}
}
