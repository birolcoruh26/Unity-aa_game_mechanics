using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickspawner : MonoBehaviour
{
    public GameObject uzunçub;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            spawner();
        }
        void spawner()
        {
            Instantiate(uzunçub, transform.position, transform.rotation);
        }
    }
}
