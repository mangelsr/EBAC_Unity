using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake method called");
    }

    void Start()
    {
        Debug.LogWarning("Start method called");
    }

    void Update()
    {
        Debug.Log("Update method called");
    }

    void FixedUpdate()
    {
        Debug.LogWarning("Fixed update method called");
    }

    void LateUpdate()
    {
        Debug.LogError("Late update method called");
    }
}
