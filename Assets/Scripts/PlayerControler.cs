using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetkeyDown(KeyCode.D))
        transform.Translate(2,0,0);

        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetkeyDown(KeyCode.A))
        transform.Translate(-2,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
