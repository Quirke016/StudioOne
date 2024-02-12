using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGlubleflip : MonoBehaviour
{
    #region SpawnFactors
    public float speed;
    public int rarityVal;
    float timeTillNextSpawn;
    public float lifeSpan;
    #endregion

    #region referances
    public Vector3 spawnPoint;
    public GameObject Glubleflip;

    public Glublefli g;
    #endregion

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // randomly gen the speed of the glublefli
            speed = Random.Range(0.5f, 10f);
            Debug.Log(speed);

            // randomly gen the life span of the glublefli
            lifeSpan = Random.Range(10f, 30f);
            Debug.Log(lifeSpan);

            // randomly give the glublefli a rarity
            rarityVal = Random.Range(1, 6);
            Debug.Log(rarityVal);

            SpawnGlubilefli();

        }
    }


    public void SpawnGlubilefli()
    {
        g.sG = this;
     g.glublefliSpeed = speed;
     g.glublefliHealth = lifeSpan;
     g.glublefliName = "temp";

        if (rarityVal == 1)
        {
            g.glublefliRarity = "Common";
        }
        else if(rarityVal == 2) 
        {
            g.glublefliRarity = "Un-Common";
        }
        else if (rarityVal == 3)
        {
            g.glublefliRarity = "Rare";
        }
        else if (rarityVal == 4)
        {
            g.glublefliRarity = "Epic";
        }
        else if (rarityVal == 5)
        {
            g.glublefliRarity = "Legendary";
        } 
    }
}
