using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int health = 10;
    // Start is called before the first frame update

    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "DamageZone")
            {
                health = health - 4;
                Debug.Log("Kollision DamageZone findet statt");
                
            }
            else
            {
                Debug.Log ("Andere Kollision");
            }

        }
}
