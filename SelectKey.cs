using UnityEngine;
using System.Collections;

public class SelectKey : MonoBehaviour
{

    public static int keyCount;

    private Ray ray;
    private RaycastHit hit;

    // Use this for initialization
    void Start()
    {
        keyCount = 0;
    }

    void Update()
    {
        if (Input.GetButtonDown("Circle"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.tag == "KEY")
                {
                    //Debug.Log("pickKey");
                    keyCount++;
                    Destroy(gameObject);
                }
            }
        }
    }
}
