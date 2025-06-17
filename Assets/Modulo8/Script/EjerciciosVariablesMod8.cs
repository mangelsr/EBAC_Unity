using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{

    int updateCounter = 0;
    float fixedUpdateAccumulator = 1;

    MeshRenderer mesh;


    string type = "";

    void Start()
    {
        float f1 = 25.06997f;
        float f2 = 3.141564f;
        int castedResult = (int)(f1 / f2);
        Debug.Log($"castedResult: {castedResult}");

        string fullName = "Miguel Sanchez Romero";

        string firstName = fullName.Substring(0, 6);
        string firstLastName = fullName.Substring(7, 7);
        string secondLastName = fullName.Substring(15, 6);
        Debug.Log($"firstName: {firstName}");
        Debug.Log($"firstLastName: {firstLastName}");
        Debug.Log($"secondLastName: {secondLastName}");

        string[] splittedName = fullName.Split(" ");
        Debug.Log($"splittedName: {splittedName}");
        foreach (string item in splittedName)
        {
            Debug.Log($"item: {item}");
        }

        mesh = gameObject.GetComponent<MeshRenderer>();
    }

    void Update()
    {
        updateCounter++;
    }

    void FixedUpdate()
    {
        fixedUpdateAccumulator *= 1.1f;

        if (updateCounter % 2 == 0)
        {
            type = "Even";
        }
        else
        {
            type = "Odd";
        }

        switch (type)
        {
            case "Even":
                mesh.material.color = Color.white;
                break;
            case "Odd":
                mesh.material.color = Color.black;
                break;
            default:
                mesh.material.color = Color.white;
                break;
        }

        string convertedAccumulator = $"{fixedUpdateAccumulator:0.0000}";
        Debug.Log($"convertedAccumulator: {convertedAccumulator}");
    }
}
