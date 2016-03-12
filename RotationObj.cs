using UnityEngine;
using System.Collections;

public class RotationObj : MonoBehaviour {
    private float angleY;
    private float angleX;
    private float speed = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        // right rotation
        if (Input.GetKey(""))
        {
            angleY += 200 * Time.deltaTime * speed;
            transform.eulerAngles = new Vector3(0, angleY, 0);
        }
        // left rotation
        if (Input.GetKey(""))
        {
            angleY += 200 * Time.deltaTime * speed;
            transform.eulerAngles = new Vector3(0, angleY, 0);
        }
        // up rotation
        if (Input.GetKey(""))
        {
            angleX += 200 * Time.deltaTime * speed;
            transform.eulerAngles = new Vector3(angleX, 0, 0);
        }

        // down rotation
        if (Input.GetKey(""))
        {
            angleX += 200 * Time.deltaTime * speed;
            transform.eulerAngles = new Vector3(angleX, 0, 0);
        }
    }
}
