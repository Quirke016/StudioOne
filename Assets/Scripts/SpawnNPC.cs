using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNPC : MonoBehaviour
{
    float popVal;

    public StatsManeager sM;

    private void Update()
    {
        popVal = sM.popularity;
    }

    //spawn npc based on popularity
    //spawn a bunch of npcs at the start of each day
}
