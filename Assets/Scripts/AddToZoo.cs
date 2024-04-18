using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddToZoo : MonoBehaviour
{
    [SerializeField] int number;
    public Glublefli g;
    public GameObject manager;
    public StatsManeager sM;
    public ZooManager zM;

    public TextMeshProUGUI cantCatch;

    private void Start()
    {
        sM = GameObject.Find("ManagerManager").GetComponent<StatsManeager>();
        zM = GameObject.Find("ManagerManager").GetComponent<ZooManager>();
    }

    public void OnMouseUpAsButton()
    {
        zM = GameObject.Find("ManagerManager").GetComponent<ZooManager>();
        if (zM.maxGloobelfub > zM._gloobelfub.Count)
        {
            Debug.Log(g.glublefliRarity.ToString());
            GameObject.Find("ManagerManager").GetComponent<ZooManager>().AddGloobelfub(g.glublefliRarity);


            Destroy(gameObject);
        }

        if (zM.maxGloobelfub <= zM._gloobelfub.Count)
        {
            StartCoroutine(CantCatchText());
        }
    }

    IEnumerator CantCatchText()
    {
        cantCatch.gameObject.SetActive(true);

        yield return new WaitForSeconds(2.5f);

        cantCatch.gameObject.SetActive(false);
    }


}
