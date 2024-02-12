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
    public GameObject glubleflip;

    public Glublefli g;
    #endregion

    Vector3 spawnPos;
    // Update is called once per frame
    private void Start()
    {
        SpawnGlubilefli();
        SpawnGlubilefli();
        SpawnGlubilefli();
        SpawnGlubilefli();
        SpawnGlubilefli();
        StartCoroutine(Spawn());
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            SpawnGlubilefli();
        } 
    }

    public void SpawnGlubilefli()
    {
        spawnPos = new Vector3(Random.Range(-10, 10), 1, Random.Range(-10, 10));
        Instantiate(glubleflip, spawnPos, Quaternion.identity);
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        float spwanTime = Random.Range(0.1f, 30f);
 
        yield return new WaitForSeconds(spwanTime);

        SpawnGlubilefli();
    }
}
