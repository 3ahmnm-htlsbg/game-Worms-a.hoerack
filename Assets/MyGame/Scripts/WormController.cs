﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormController : MonoBehaviour
{
     public float force;
     public Rigidbody worm;
     public Vector3 moveRight;
     public Vector3 moveLeft;
     public Vector3 jump;
     
     public GameObject bullets;
     public GameObject canon;
     public float shoot = 100;
     public Transform bulletPosition; 

     public int health = 10;
     public Text healthText;

         
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject sphere = Instantiate (bullets, bulletPosition.position, Quaternion.identity);
            sphere.GetComponent<Rigidbody>().AddForce(canon.transform.up * shoot);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            canon.transform.Rotate(-5, 0, 0, Space.Self);
            Debug.Log ("Button Input detected");
        }

        if (Input.GetKey(KeyCode.E))
        {
            canon.transform.Rotate(5, 0, 0, Space.Self);
            Debug.Log ("Button Input detected");
      }
      DisplayHealth();
    }  
    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "DamageZone")
            {
                health = health - 1;
                Debug.Log("Kollision DamageZone findet statt");
                
            }
            else
            {
                Debug.Log ("Andere Kollision");
            }
            if (collision.gameObject.tag == "healthpackage")
            {
                health = health +2;
                Debug.Log ("healthpackage achieved");
                Destroy(collision.gameObject);
            }
        }
    void DisplayHealth()
            {
                healthText.text = "Health: " + health.ToString();
            }
}
    
