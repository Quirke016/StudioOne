using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public bool flip = false;
    public GameObject hGround;
    public GameObject sGround;
    // Update is called once per frame
    void Update()
    {
        if (flip)
        {
            hGround.SetActive(false);
            sGround.SetActive(true);
        }    
        else
        {
            hGround.SetActive(true);
            sGround.SetActive(false);
        }

    }
}
