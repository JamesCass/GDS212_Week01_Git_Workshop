using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("BOOOM");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("BOOMSTOPPED");
        }
    }
}
