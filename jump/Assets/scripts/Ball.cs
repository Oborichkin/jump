using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public GameObject go;

    private Rigidbody rb;

    private float xAxis = 0.0f;
    private float deviceWidth;
    private float smoothness = 0.1f;
    private float storedVelocity = 10f;
    private float temp;

    private void Awake()
    {
        Application.targetFrameRate = 300;
    }

    // Use this for initialization
    void Start () {
        deviceWidth = Screen.width;
        temp = Time.time;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < -1f)
            Application.LoadLevel(Application.loadedLevel);
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            xAxis = (t.position.x / (deviceWidth / 2)) - 1;
            transform.position = Vector3.Lerp(transform.position, new Vector3(xAxis * 4f, transform.position.y, transform.position.z), smoothness);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision!");
        // Debug.Log("Time passed " + (Time.time - temp));
        Debug.Log(collision.transform.position.z);
        go.transform.Translate(0, 0, -collision.transform.position.z/2);
        rb.velocity = new Vector3(rb.velocity.x, storedVelocity, rb.velocity.z);
        temp = Time.time;
    }
}

