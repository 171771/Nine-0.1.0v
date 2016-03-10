using UnityEngine;
using System.Collections;

public class OpenBox : MonoBehaviour
{
    private Animator animator;

    private Ray ray;
    //private RaycastHit hit;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        //animator.SetBool("IsOpen", true);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(Laser.ray, out Laser.hit, 2))
        {
            if (Laser.hit.collider.tag == "BOX")
            {
               // Debug.Log("collider tag openBox = " + Laser.hit.collider.tag);
                animator.SetBool("IsOpen", true);
                SelectKey.keyCount--;
            }
        }
        // }
    }
}
