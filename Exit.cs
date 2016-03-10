using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

    private Ray ray;

	// Use this for initialization
	void Start () {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 2))
            {
                if (hit.collider.name == "Exit")
                {
                    Debug.Log("Exit = " + Laser.hit.collider.name);
                    SelectKey.keyCount--;
                    gameObject.SetActive(false);
                }
            }
        }
    }
}
