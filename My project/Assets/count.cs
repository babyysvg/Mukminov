using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count : MonoBehaviour
{
    public Text CounterText;
    public collision CubeScript; 
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        CounterText.text = "score " + CubeScript.score;
    }
}
