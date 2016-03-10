using UnityEngine;
using System.Collections;

public class SelectMirror : MonoBehaviour
{
    static public int mirrorCount = 0;
    static public int keyCount = 0;
    public bool isSelected = false;
    public GameObject SelectedMirror;

    void Update()
    {
        if (Input.GetButtonDown("Circle"))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

            if (Input.GetButtonDown("Circle") && hit)
            {
                Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.name == "Mirror in BlueRoom_1")
                {
                    isSelected = true;
                    SelectedMirror = hitInfo.transform.gameObject;
                    mirrorCount++;
                    Destroy(SelectedMirror);
                }
                else if (hitInfo.transform.gameObject.name == "Mirror in BlueRoom_2")
                {
                    //Debug.Log("isisis");
                    isSelected = true;
                    SelectedMirror = hitInfo.transform.gameObject;
                    mirrorCount++;
                    Destroy(SelectedMirror);
                }
            }
        }
    }
}
