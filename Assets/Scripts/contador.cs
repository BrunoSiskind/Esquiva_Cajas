using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contador : MonoBehaviour
{
    public TextMeshProUGUI Contador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Contador.text = Time.time.ToString("F2");
    }
}
