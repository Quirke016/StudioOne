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
    //[SerializeField] Renderer r;
    [SerializeField] GameObject thisTwo;
    public Movement m;

    #region Glublefli
    public GameObject nOne;
    public GameObject nTwo;
    public GameObject nThree;
    public GameObject nFour;
    public GameObject nFive;

    #endregion
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //hides all the sprites
        nOne.SetActive(false);
        nTwo.SetActive(false);
        nThree.SetActive(false);
        nFour.SetActive(false);
        nFive.SetActive(false);
       

        // randomly gen the speed of the glublefli
        glublefliSpeed = Random.Range(0.5f, 10f);
        //Debug.Log(glublefliSpeed);

        // randomly gen the life span of the glublefli
        glublefliHealth = Random.Range(6.5f, 20.5f);
        //Debug.Log(glublefliHealth);

        // randomly give the glublefli a rarity
        int rarityVal = Random.Range(1, 2); 
        //Debug.Log(rarityVal);

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
                            //r.material.color = Color.white;
                            nFive.SetActive(true);
                            m.g_Speed = 3f;
                        }

                        else
                        {
                            glublefliRarity = "Epic";
                            //r.material.color = Color.yellow;
                            nFour.SetActive(true);
                            m.g_Speed = 6;
                        }

                    }

                    else
                    {
                        glublefliRarity = "Rare";
                        //r.material.color = Color.red;
                        nThree.SetActive(true);
                        m.g_Speed = 8.5f;
                    }
                }

                else
                {
                    glublefliRarity = "Un-Common";
                    //r.material.color = Color.blue;
                    nTwo.SetActive(true);
                    m.g_Speed = 1;
                }
            }
            
            else
            {
                glublefliRarity = "Common";
                //r.material.color = Color.green;
                nOne.SetActive(true);
                m.g_Speed = 4;
            }

        }

        StartCoroutine(LifeSpan());
        //tMP.text = glublefliRarity;

    }

    IEnumerator LifeSpan()
    {
        yield return new WaitForSeconds(glublefliHealth);
        Destroy(thisTwo);
    }
}
