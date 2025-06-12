using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public List<GameObject> cubeList;
    public float scalingFactor;
    public int cubeNum = 0;

    void Start()
    {
        cubeList = new List<GameObject>();
    }

    void Update()
    {
        cubeNum++;
        GameObject tmpGameObject = Instantiate(cubePrefab);
        tmpGameObject.name = $"CubeN{cubeNum}";
        Color color = new Color(Random.value, Random.value, Random.value);
        tmpGameObject.GetComponent<MeshRenderer>().material.color = color;
        tmpGameObject.transform.position = Random.insideUnitSphere;


        cubeList.Add(tmpGameObject);
        List<GameObject> objectsToDelete = new List<GameObject>();
        foreach (GameObject item in cubeList)
        {
            float scale = item.transform.localScale.x;
            scale *= scalingFactor;
            item.transform.localScale = Vector3.one * scale;

            if (scale < 0.1)
            {
                objectsToDelete.Add(item);
            }
        }

        foreach (GameObject item in objectsToDelete)
        {
            cubeList.Remove(item);
            Destroy(item);
        }
    }
}
