using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Glublefli : MonoBehaviour
{
    #region Stats
    public float glublefliSpeed;
    public float glublefliHealth = 5;
    public string glublefliName;
    public string glublefliRarity;
    #endregion

    #region Refs;
    public TextMeshPro tMP;
    [SerializeField] Renderer r;
    [SerializeField] GameObject thisTwo;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        // randomly gen the speed of the glublefli
        glublefliSpeed = Random.Range(0.5f, 10f);
        Debug.Log(glublefliSpeed);

        // randomly gen the life span of the glublefli
        glublefliHealth = Random.Range(6.5f, 20.5f);
        Debug.Log(glublefliHealth);

        // randomly give the glublefli a rarity
        int rarityVal = Random.Range(1, 2); 
        Debug.Log(rarityVal);

        if (rarityVal <= 1)
        {
            int uncommonCheck = Random.Range(1, 100);

            if (uncommonCheck < 75)
            {
                int rareCheck = Random.Range(1, 100);

                if (rareCheck < 50)
                {
                    int epicCheck = Random.Range(1, 100);

                    if (epicCheck < 25)
                    {
                        int LedgendaryCheck = Random.Range(1, 100);

                        if (LedgendaryCheck < 5)
                        {
                            glublefliRarity = "Legendary";
                            r.material.color = Color.white;
                        }

                        else
                        {
                            glublefliRarity = "Epic";
                            r.material.color = Color.yellow;
                        }

                    }

                    else
                    {
                        glublefliRarity = "Rare";
                        r.material.color = Color.red;
                    }
                }

                else
                {
                    glublefliRarity = "Un-Common";
                    r.material.color = Color.blue;
                }
            }
            
            else
            {
                glublefliRarity = "Common";
                r.material.color = Color.green;
            }

        }

        StartCoroutine(LifeSpan());
        tMP.text = glublefliRarity;

    }

    IEnumerator LifeSpan()
    {
        yield return new WaitForSeconds(glublefliHealth);
        Destroy(thisTwo);
    }
}
