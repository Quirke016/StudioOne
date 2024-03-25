using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToZoo : MonoBehaviour
{
    [SerializeField] int number;
    public Glublefli g;

    public void OnMouseUpAsButton()
    {
        Debug.Log(g.glublefliRarity.ToString());
    }


}
