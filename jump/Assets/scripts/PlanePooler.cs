using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePooler : MonoBehaviour {

    public GameObject Plane;
    public int amount = 4;
    public float amplitude = 3f;

	void Start () {
        GameObject first = (GameObject)Instantiate(Plane);
        first.transform.position = Vector3.zero;
        first.transform.parent = gameObject.transform;
        for (int i = 1; i < amount; i++)
        {
            GameObject obj = (GameObject)Instantiate(Plane);
            obj.transform.parent = gameObject.transform;
            obj.transform.position = new Vector3((Random.value - 0.5f) * amplitude / 0.5f, 0, i * 2.16f);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
