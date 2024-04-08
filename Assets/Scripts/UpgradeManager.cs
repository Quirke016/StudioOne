using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public StatsManeager sM;
    public TextMeshProUGUI luckCost;
    int luckprice = 10;
    public TextMeshProUGUI plotCost;
    public TextMeshProUGUI tipsCost;
    public TextMeshProUGUI feeCost;
    public TextMeshProUGUI killCost;
    public TextMeshProUGUI securityCost;

    private void Start()
    {

        luckCost.text = ("Buy $" + luckprice);
    }
    public void Luck()
    {
        int tmpInt;
        if (sM.money > luckprice)
        {
            sM.money -= luckprice;
            sM.luck++;
            tmpInt = luckprice;
            luckprice = (int)(tmpInt * 1.5f);
            luckCost.text = ("Buy $" + luckprice); 
        }
    }

    public void Tip()
    {

    }
    
    public void Fee()
    {

    }
    
    public void Plot()
    {

    }

    public void Food()
    {

    }

    public void Security()
    {

    }

}
