using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class StatsManeager : MonoBehaviour
{
    #region Stats
    public int money;
    public int food;
    public float popularity;
    public float dayLength;
    public int dayCount;
    public float difficulty;

    #region TMPRefs

    public TextMeshProUGUI moneyAmount;
    public TextMeshProUGUI foodAmount;
    public TextMeshProUGUI popularityAmount;
    public TextMeshProUGUI dayCountAmount; 

    #endregion
    #endregion

    private void Start()
    {
        
    }
    public void Update()
    {
        if (food >= 0 && money >= 0) 
        {
            //end game
        }

        if (popularity >= 0)
        {
            //end game
        }
    }

    IEnumerator DayCycle ()
    {

        yield return new WaitForSeconds(dayLength);


    }
}
