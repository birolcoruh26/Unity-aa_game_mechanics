using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraanim : MonoBehaviour
{
    Animator anima;
    void Start()
    {
        anima = GetComponent<Animator>();
         
    }
    
    // Update is called once per frame
    void Update()
    {
        if (lowstick.gameender == true)
        {
            anima.SetBool("gameending", true);
        }
    }
}
