using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    void OnDisable()
    {
        SpawnObject();
    }

    void OnEnable()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        GameObject tmpGameObject = Instantiate(objectToSpawn);
        tmpGameObject.name = $"ToggleSpawnedObject";
        tmpGameObject.transform.position = this.transform.position;
    }
}
