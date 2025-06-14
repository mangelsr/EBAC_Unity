using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCheck : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    bool boolValue = false;

    void FixedUpdate()
    {
        bool go1BoolValue = object1.GetComponent<AndCheck>().boolValue;
        bool g2BoolValue = object2.GetComponent<OrCheck>().boolValue;

        boolValue = go1BoolValue && g2BoolValue;

        Color color = Color.black;
        if (boolValue)
        {
            color = Color.white;
        }
        gameObject.GetComponent<MeshRenderer>().material.color = color;
    }
}
