using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnNPC : MonoBehaviour
{
    float popVal;


    public GameObject nOne;
    public GameObject nTwo;
    public GameObject nThree;
     GameObject currentNPC;
     [SerializeField] GameObject spawner;

    public StatsManeager sM;

    private void Update()
    {
        popVal = sM.popularity;



    }


    private void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {

        float a = 0;
        float b;
        float c = Random.Range(1f, 3f);
        float d = 0;
        if (sM.popularity > 0)
        {
            a = -5;
        }
        if (sM.popularity < 0)
        {
            a = 5;
        }
        b = Random.Range(1f, 10f) + a;
        if (b >= 0)
        {
            b = 0;
            b += Random.Range(1f, c);
        }

        d = b * (int)sM.popularity;
        if (d <= 0)
        {
            d = b;
        }
        if (d < 10)
        {
            d = 10;
        }


        bool instantiateInWorldSpace = false;

        for (int i = (int)d; i > 0; i--)
            {

            int rand = Random.Range(1, 4);

            if (rand == 1)
            {
                currentNPC = nOne;
            }
            else if (rand == 2)
            {
                currentNPC = nTwo;
            }
            else if (rand == 3)
            {
                currentNPC = nThree;
            }

            float e = Random.Range(1f, 5f);
            if (sM.popularity < 0)
            {
                e += 5;
            }
            yield return new WaitForSeconds(e);

            Instantiate(currentNPC, spawner.transform, instantiateInWorldSpace);


        }
       

        yield return new WaitForSeconds(b);

        StartCoroutine(Spawn());
    }

 

}
