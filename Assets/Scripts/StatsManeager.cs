using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StatsManeager : MonoBehaviour
{
    #region Stats
    public int money = 10;
    public int food = 10;
    public float popularity = 10;
    public float dayLength;
    public int dayCount;
    public float difficulty;

    #region refs
    public GameObject dayCountScreen;
    public GameObject endScreenA;
    public Flip f;

    #region TMPRefs
    public TextMeshProUGUI moneyAmount;
    public TextMeshProUGUI foodAmount;
    public TextMeshProUGUI popularityAmount;
    public TextMeshProUGUI dayCountAmount;
    public TextMeshProUGUI dayCountConstant;

    #endregion
    #endregion
    #endregion

    private void Start()
    {
        dayLength = 5;
        StartCoroutine(DayCycle());
    }
    public void Update()
    {
        moneyAmount.text = ("Coin:" + money.ToString());
        popularityAmount.text = ("Popularity:" + (int)popularity).ToString();
        foodAmount.text = ("Food:" + (food).ToString());
        dayCountConstant.text = ("Day:" + (string)dayCount.ToString());


        if (food <= 0 && money <= 0) 
        {
            f.flip = true;
        }

        if (popularity <= -100)
        {
            endScreenA.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    IEnumerator DayCycle ()
    {

        yield return new WaitForSeconds(dayLength);

        dayCount++;
        if (f.flip)
        {
            popularity -= Random.Range(1.001f, 10f);
        }

        difficulty += Random.Range(0.1f, 5f);
        dayCountScreen.SetActive(true);

        dayCountAmount.text = dayCount.ToString();
        dayCountConstant.text = dayCount.ToString();

        yield return new WaitForSeconds(2.5f);

        dayCountScreen.SetActive(false);

        StartCoroutine(DayCycle());



    }
}
