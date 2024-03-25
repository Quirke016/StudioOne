using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CatchGlubleflib : MonoBehaviour
{
    public Ray ray;

    public void Awake()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }
    public void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Vector3 pointToLook = ray.GetPoint(Mathf.Infinity);
            Debug.DrawLine(ray.origin, pointToLook, Color.cyan);
            Debug.Log(hit.transform.name);
            Debug.Log("hit");
        }
    }

}
