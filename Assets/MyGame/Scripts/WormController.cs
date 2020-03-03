using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
     public float force;
     public Rigidbody worm;
     public Vector3 moveRight;
     public Vector3 moveLeft;
     public Vector3 jump;
     
     void Start()
     {
         //gameObject.GetComponent<Rigidbody>().AddForce(0,0,1);
     }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D ist gedrückt");
            worm.AddForce(moveRight);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W ist gedrückt");
            worm.AddForce(jump);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A ist gedrückt");
            worm.AddForce(moveLeft);

        }
    }
    
}
