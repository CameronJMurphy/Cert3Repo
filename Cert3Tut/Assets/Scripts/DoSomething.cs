using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoSomething : MonoBehaviour
{
    public int value;
    // Start is called before the first frame update
    void Start()
    {

        value *= 2;
        value -= 5;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
