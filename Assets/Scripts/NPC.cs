using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    float speed;
    GameObject nPC;
    Rigidbody rb;
    int dayStatic;
    int dayCount;


    private void Awake()
    {
        speed = Random.Range(3f, 30f);
        rb = GetComponent<Rigidbody>();
    }
    //move
    private void Update()
    {
        Vector3 move = new Vector3(1, 0, 0);
        rb.MovePosition(transform.position + move * Time.deltaTime * speed);
    }
    //add money based on popularity
    //remove npc at day end
}
