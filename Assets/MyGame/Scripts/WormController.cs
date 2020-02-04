using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    void update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Wird aufgerufen!");
        }
    }
}
