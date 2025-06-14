using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ToggleOnFixedUpdate : MonoBehaviour
{
    public bool boolValue = false;

    void FixedUpdate()
    {
        boolValue = !boolValue;
        Color color = Color.black;
        if (boolValue)
        {
            color = Color.white;
        }
        gameObject.GetComponent<MeshRenderer>().material.color = color;
    }
}
