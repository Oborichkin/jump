using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {
    private bool flag = true;
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, -3f * Time.deltaTime);
        if (transform.position.z <= 0 && flag)
        {
            // Debug.Log("Im at 0 " + Time.time);
            flag = false;
        }

        if (transform.position.z < -2.16f)
        {
            transform.position = new Vector3((Random.value - 0.5f) * 2f / 0.5f, 0, 6.48f);
            flag = true;
        }
	}
}
