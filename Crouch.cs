using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Crouch : MonoBehaviour
{
    public int tongle = 0;
    public Vector3 localScale;

    Vector3 pos;
    Vector3 crouchT;
    Vector3 crouchF;

    private FirstPersonController fpsCtrl;

    // Use this for initialization
    void Start()
    {        
        crouchT.Set(0, -0.4f, 0);
        crouchF.Set(0, 0.4f, 0);
        pos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {       
        if (tongle == 0)
        {
            if (Input.GetButtonDown("Oculus_GearVR_RIndexTrigger"))
            {
                transform.localScale += crouchT;
                tongle = 1;
                fpsCtrl.m_WalkSpeed -= 2f;
            }
            return;
        }

        if (tongle == 1)
        {
            if (Input.GetButtonDown("Oculus_GearVR_RIndexTriggerl"))
            {
                pos.y += 0.5f;
                transform.localScale += crouchF;
                tongle = 0;
                fpsCtrl.m_WalkSpeed += 2f;
            }
            return;
        }
    }
}