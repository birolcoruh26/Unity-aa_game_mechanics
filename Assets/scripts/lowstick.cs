using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowstick : MonoBehaviour
{
    Rigidbody2D rb;
    public float sp;
    public bool engellihareketmi;
    public GameObject gamemanager;
    public static bool gameender;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gamemanager = GameObject.FindGameObjectWithTag("manager");
    }

    // Update is called once per frame
    void Update()
    {
        if (engellihareketmi == false)
        {
            rb.MovePosition(rb.position + Vector2.up * sp * Time.deltaTime); // bu nokta çubuðun yukarý gidiþi
        }
    }


     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "S")
        {
            transform.SetParent(col.transform);
            engellihareketmi = true ;
        }
        if(col.gameObject.tag == "lowercircle")
        {
            gameender = true;
            gamemanager.GetComponent<ganeending>().End();
        }
    }
}
