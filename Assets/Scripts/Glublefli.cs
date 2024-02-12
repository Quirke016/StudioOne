using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Glublefli : MonoBehaviour
{
    #region Stats
    public float glublefliSpeed;
    public float glublefliHealth;
    public string glublefliName;
    public string glublefliRarity;
    #endregion

    #region Refs
    public SpawnGlubleflip sG;
    public TextMeshPro tMP;
    #endregion


    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(LifeSpan());
        tMP.text = glublefliRarity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LifeSpan()
    {
        yield return new WaitForSeconds(glublefliHealth);
        Destroy(this);
    }
}
