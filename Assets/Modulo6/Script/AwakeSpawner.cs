using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    void Awake()
    {
        GameObject tmpGameObject = Instantiate(objectToSpawn);
        tmpGameObject.name = $"AwakeSpawnedObject";
        tmpGameObject.transform.position = this.transform.position;
    }

}
