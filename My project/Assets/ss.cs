using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss : MonoBehaviour
{
    public GameObject sf;



    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Obj aktiv");
            sf.SetActive(true);
        }
        if (Input.GetKey(KeyCode.B))
        {
            Debug.Log("Obj ne_aktiv");
            sf.SetActive(false);
        }
    }
}
