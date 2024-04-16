using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooManager : MonoBehaviour
{

    List<GameObject> _gloobelfub = new List<GameObject>();

    public Void AddGloobelfub()
    {

        _gloobelfub.Add(gameObject);
    }
}
