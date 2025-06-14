using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorizeOnAwake : MonoBehaviour
{
    void Awake()
    {
        Color color = new Color(Random.value, Random.value, Random.value);
        gameObject.GetComponent<MeshRenderer>().material.color = color;
    }
}
