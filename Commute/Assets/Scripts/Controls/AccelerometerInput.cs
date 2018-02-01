using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelerometerInput : MonoBehaviour {

    [SerializeField]
    Text accelerationXText;

    [SerializeField]
    Text amountOfFingers;

    [SerializeField]
    Text amplifier;

    [SerializeField]
    [Range(0.5f, 10f)]
    float accelerationAmplifier = 1f; // Determines how strong the acceleration input should be mapped onto the object


    private void Start()
    {
        Debug.Log(Input.simulateMouseWithTouches);
    }

    // Update is called once per frame
    void Update () {

        foreach (Touch touch in Input.touches)
        {
            if (TouchControls.TouchOnLeftSide(touch)) {
                accelerationAmplifier -= 0.2f;
            } else if (TouchControls.TouchOnRightSide(touch)) {
                accelerationAmplifier += 0.2f;
            }
        }


        accelerationXText.text = "Acceleration.x = " + Input.acceleration.x;
        amountOfFingers.text = "Amount of fingers = " + Input.touchCount;
        amplifier.text = "Amplifier = " + accelerationAmplifier;
	}

    public float GetXMovement() {
        return Input.acceleration.x * accelerationAmplifier;
    }
}
