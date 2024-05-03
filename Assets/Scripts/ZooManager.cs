using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZooManager : MonoBehaviour
{

    public List<GameObject> _gloobelfub = new List<GameObject>();
    List<string> _gloobelfubRarity = new List<string>();
    public int maxGloobelfub;

    public Glublefli g;


    #region goobelfun

    public TextMeshProUGUI slotOne;
    public TextMeshProUGUI slotTwo;
    public TextMeshProUGUI slotThree;
    //free slots

    public bool hasFirstUpgrade = false;
    public TextMeshProUGUI slotFour;
    public TextMeshProUGUI slotFive;
    //upgrade 1

    public bool hasSecondUpgrade = false;
    public TextMeshProUGUI slotSix;
    public TextMeshProUGUI slotSeven;
    //upgrade 2

    public bool hasfinalUpgrade;
    public TextMeshProUGUI slotEight;
    //final upgrade

    #endregion

    public void Update()
    {
        #region rarity

        if (_gloobelfub[0] != null)
        {
            AddRarity("f");
        }





        #endregion 






        #region free slots
        if (_gloobelfub[0] != null)
        {
            
            slotOne.text = _gloobelfub[0].ToString();
        }
        if (_gloobelfub[0] == null)
        {
            slotOne.text = "Empty";
        }
        //-------------------------------
        if (_gloobelfub[0] != null)
        {
            slotTwo.text = _gloobelfub[1].ToString();
        }
        if (_gloobelfub[0] == null)
        {
            slotTwo.text = "Empty";
        }
        //-------------------------------
        if (_gloobelfub[0] != null)
        {
            slotThree.text = _gloobelfub[2].ToString();
        }
        if (_gloobelfub[0] == null)
        {
            slotThree.text = "Empty";
        }
        //free slots
        #endregion

        #region upgrade1
        if (hasFirstUpgrade)
        {
            slotOne.text = _gloobelfub[3].ToString();
            slotOne.text = _gloobelfub[4].ToString();
        }
        // UGRADE 1

        #endregion

        #region upgrade2
        if (hasSecondUpgrade)
        {
            slotOne.text = _gloobelfub[5].ToString();
            slotOne.text = _gloobelfub[6].ToString();

        }
        //upgrade 2
        #endregion

        #region finalupgrade
        if (hasfinalUpgrade)
        {
            slotOne.text = _gloobelfub[7].ToString();
        }
        //final upgrade
        #endregion





    }

    private void Start()
    {
        maxGloobelfub = 3;
    }

    public void AddGloobelfub(string rarity)
    {
        
        _gloobelfub.Add(gameObject);
    }

    public void AddRarity(string rarity)
    {
    
    }
}
