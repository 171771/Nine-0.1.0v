using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]

public class Laser : MonoBehaviour
{
    // stlqkfsjadmltoRl
    private Transform goTransform;
    private LineRenderer lineRenderer;

    static public Ray ray;
    static public RaycastHit hit;

    private Vector3 inDirection;

    public int nReflections = 2;

    private int nPoints;

    void Awake()
    {
        goTransform = this.GetComponent<Transform>();
        lineRenderer = this.GetComponent<LineRenderer>();
    }

    void Update()
    {
        MirrorReflection();
    }

    void MirrorReflection()
    {
        nReflections = Mathf.Clamp(nReflections, 1, nReflections);
        ray = new Ray(goTransform.position, goTransform.forward);

        Debug.DrawRay(goTransform.position, goTransform.forward * 100, Color.magenta);

        nPoints = nReflections;
        lineRenderer.SetVertexCount(nPoints);
        lineRenderer.SetPosition(0, goTransform.position);

        for (int i = 0; i <= nReflections; i++)
        {
            //Debug.Log("nReflection = " + nReflections);
            if (i == 0)
            {
                if (Physics.Raycast(ray.origin, ray.direction, out hit, 100))
                {
                    // inDirection = Vector3.Reflect(ray.direction, hit.normal);
                    inDirection = Vector3.Reflect(hit.point - this.transform.position, hit.normal);
                    ray = new Ray(hit.point, inDirection);

                    Debug.DrawRay(hit.point, hit.normal * 3, Color.blue);
                    Debug.DrawRay(hit.point, inDirection * 100, Color.magenta);

                    if (nReflections == 1)
                    {
                        lineRenderer.SetVertexCount(++nPoints);
                        lineRenderer.SetPosition(i, hit.point);
                    }
                    //lineRenderer.SetPosition(i + 1, hit.point);
                }
                lineRenderer.SetPosition(i + 1, hit.point);
            }

            else
            {
                if (Physics.Raycast(ray.origin, ray.direction, out hit, 100))
                {
                    inDirection = Vector3.Reflect(hit.point - this.transform.position, hit.normal);
                    ray = new Ray(hit.point, inDirection);

                    Debug.DrawRay(hit.point, hit.normal * 3, Color.blue);
                    Debug.DrawRay(hit.point, inDirection * 100, Color.magenta);

                    //Print the name of the object the cast ray has hit
                    //Debug.Log("Object name : " + hit.transform.name);
                    if (hit.collider.tag == "MIRROR")
                    {
                        lineRenderer.SetVertexCount(++nPoints);
                        lineRenderer.SetPosition(i + 1, ray.direction);
                    }
                }
                lineRenderer.SetVertexCount(++nPoints);
                lineRenderer.SetPosition(i + 1, hit.point);
                //Debug.Log("hit.collider = " + hit.collider.tag);
            }
        }
    }
}