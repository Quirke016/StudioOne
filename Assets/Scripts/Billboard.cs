using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{

    public GameObject viewer; //this is the object that the billboard will look at (I.E. the Camera)
    public GameObject billboard; // this is the object that always faces the viewer


    private void Start()
    {
        viewer = GameObject.Find("Main Camera");
    }

    // Update is called once per frame   
    void Update()
    {
        billboard.transform.LookAt(viewer.transform);
    }
}
