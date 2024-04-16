using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public StatsManeager sM;
    public float entryFee;
    public float tip;
    public float maxTip = 1f;



    private void OnTriggerEnter(Collider col)
    {
        AddMoney();
        Destroy(col.gameObject);
    }

    public void AddMoney()
    {
        tip = Random.Range(0f, maxTip);
        sM.money += (int)((sM.difficulty / 75) + (tip * sM.luck) + entryFee);
        sM.popularity += Random.Range(-1.5f, 3.5f);
    }
}