using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private int objNum = 0;

    void Update()
    {
        objNum++;
        GameObject tmpGameObject = Instantiate(objectToSpawn);
        tmpGameObject.name = $"ObjectN{objNum}";
        tmpGameObject.transform.position = Random.insideUnitSphere;
    }
}
