using UnityEngine;
using System.Collections;

public class EquipMirror : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    static public bool isEquip = false;
    private GameObject childobj1;
    private GameObject childobj2;

    // Use this for initialization
    void Start()
    {
        childobj1 = GameObject.Find("Mirror_1");
        childobj2 = GameObject.Find("Mirror_2");
        childobj1.SetActive(false);
        childobj2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Circle"))
        {
            hit = new RaycastHit();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 2))
            {
                if (hit.collider.name == "BoxSupport_1" && SelectMirror.mirrorCount > 0)
                {
                    isEquip = true;
                    SelectMirror.mirrorCount--;
                    Debug.Log("Equip is" + isEquip);
                    Debug.Log(SelectMirror.mirrorCount);
                    childobj1.SetActive(true);
                }
                
                else if (hit.collider.name == "BoxSupport_2" && SelectMirror.mirrorCount > 0)
                {
                    isEquip = true;
                    SelectMirror.mirrorCount--;
                    Debug.Log("Equip is" + isEquip);
                    Debug.Log(SelectMirror.mirrorCount);
                    childobj2.SetActive(true);
                }
            }
        }
    }
}
