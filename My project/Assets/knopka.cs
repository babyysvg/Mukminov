using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knopka : MonoBehaviour
{
    public GameObject sf;
    public void button()
    {
        if (sf.active == true)
        {
            Debug.Log("Obj aktiv");
        }
        if (sf.active == false)
        {
            Debug.Log("Obj ne_aktiv");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
