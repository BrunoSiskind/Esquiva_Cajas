using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCajaMov : MonoBehaviour
{   
    public float velocidad = 3f;
     float InitialYValue;
    // Start is called before the first frame update
    void Start()
    {
        
        InitialYValue = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down*velocidad*Time.deltaTime);
    }

    public void Moveboxtorandomposition(){
        Vector3 newPosition = transform.position;
        int RandomX = 0;
        RandomX = Random.Range(0,3);
        if (RandomX == 0){
            newPosition.x = -2;
        }
        else if (RandomX == 1){
            newPosition.x = 0;
        }
        else{
            newPosition.x = 2;
        }
        
        newPosition.y = InitialYValue;
        transform.position = newPosition;
    }
}
