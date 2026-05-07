using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cajacollisiondetection : MonoBehaviour
{
    public BadCajaMov cajamovementScript;
    float InitialYValue;

    // Start is called before the first frame update
    void Start()
    {
        cajamovementScript = GetComponent<BadCajaMov>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Piso"))
        {
            cajamovementScript.Moveboxtorandomposition();
        }
    }
}
