using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public int x;
    // Start is called before the first frame update
    void Start()
    {

        if(x>10) {
            Debug.Log("x ist größer als 10");
    }    
        else {
            Debug.Log("x ist kleiner als 10");
    }  
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
