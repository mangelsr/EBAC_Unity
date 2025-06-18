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

        /*
        Crea dos variables string que guarden valores numéricos de miles, pasalas a tipos de datos 
        numéricos utilizando la función tryParse, realiza una operación con ellas e imprime el resultado.
        */
        string number1 = "19972506";
        string number2 = "10300017";
        float n1, n2;

        float.TryParse(number1, out n1);
        float.TryParse(number2, out n2);

        float result = n1 / n2;

        Debug.Log($"result: {result}");


        /*
        Crea un string con una oración, imprime sólo los caracteres que se encuentren en un índice par, 
        por ejemplo “Hola Mundo”, solo deberá imprimir los caracteres: H,l, ,u,d. 
        (recuerda para qué sirve el uso del operador módulo).
        */
        string sentence = "I'm learning Unity in EBAC";
        string evenChars = "";
        for (int i = 0; i < sentence.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenChars += $"{sentence[i]},";
            }
        }
        evenChars.Substring(0, evenChars.Length - 1);
        Debug.Log($"evenChars: {evenChars}");


        /*
        Crea un string guarda, una oración en él y elimina los primeros 5 caracteres de este 
        ya sea con la función substring, Split,  o cualquier otro método disponible en la clase String
        */
        string lastSentence = "This is the last exercise of the homework";
        string reducedString = lastSentence.Substring(5, lastSentence.Length - 5);
        Debug.Log($"lastSentence: {lastSentence}");
        Debug.Log($"reducedString: {reducedString}");

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
