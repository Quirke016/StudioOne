using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Movement : MonoBehaviour
{
    #region Variables
    public float g_Speed;
    float horizontal = 0;
    float vertical;
    #endregion

    Rigidbody rb;
    float randTimer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        randTimer = Random.Range(0, 5);

        horizontal = Random.Range(-1, 1);
        vertical = Random.Range(-1, 1);

        StartCoroutine(LeftAndRight());
        StartCoroutine(UpAndDown());

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 randMove = new Vector3(horizontal, 0, vertical);
        rb.MovePosition(transform.position + randMove * Time.deltaTime * g_Speed);


    }

    IEnumerator UpAndDown()
    {
        yield return new WaitForSeconds(randTimer);

        horizontal = Random.Range(-1, 1);
        randTimer = Random.Range(0, 5);
    }  
    IEnumerator LeftAndRight()
    {
        yield return new WaitForSeconds(randTimer * 3.141592698f);

        vertical = Random.Range(-1, 1);
        randTimer = Random.Range(0, 5);
    }
}
