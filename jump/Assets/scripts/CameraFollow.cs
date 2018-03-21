using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private float xAxis;
    private float deviceWidth;
    private float smoothness = 0.05f;

	// Use this for initialization
	void Start () {
        deviceWidth = Screen.width;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            xAxis = (t.position.x / (deviceWidth / 2)) - 1;
            transform.position = Vector3.Lerp(transform.position, new Vector3(xAxis * 1.5f, transform.position.y, transform.position.z), smoothness);
        }
    }
}
