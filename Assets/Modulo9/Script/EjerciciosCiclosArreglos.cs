using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class EjerciciosCiclosArreglos : MonoBehaviour
{
    void Start()
    {
        /*
        Crea dos arreglos unidimensionales de números enteros y llenalos usando un ciclo y la función Random.Range 
        con números enteros, después crea un tercer arreglo y llénalo con la suma de los elementos de 
        los primeros dos: por ejemplo arr3[5] = arr1[5]+arr[5]
        */
        int size = 5;
        int minValue = 0;
        int maxValue = 10;

        int[] array1 = new int[size];
        int[] array2 = new int[size];

        for (int i = 0; i < size; i++)
        {
            array1[i] = Random.Range(minValue, maxValue);
            array2[i] = Random.Range(minValue, maxValue);
        }
        Debug.Log($"Array1: [ {string.Join(", ", array1)} ]");
        Debug.Log($"Array2: [ {string.Join(", ", array2)} ]");

        int[] resultArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            resultArray[i] = array1[i] + array2[i];
        }
        Debug.Log($"resultArray: [ {string.Join(", ", resultArray)} ]");

        /*
        Crea un arreglo de strings y llena cada elemento con una palabra de una oración, 
        después utilizando un ciclo foreach concatena sus elementos e imprime la oración 
        completa en la consola en un solo string.
        */
        string[] words = { "Hello", "world", "i", "am", "learning", "GameDev", "with", "Unity" };
        string sentence = "";
        foreach (string word in words)
        {
            sentence = sentence + " " + word;
        }
        Debug.Log($"words: [ {string.Join(", ", words)} ]");
        Debug.Log(sentence);


        /*
        Crea un arreglo bidimensional de enteros de 2 renglones y 3 columnas al menos y 
        multiplícalo por un arreglo unidimensional de enteros con la cantidad de elementos 
        que se alinee a la cantidad de renglones del arreglo bidimensional de tal manera que 
        la operación sea una multiplicación matriz * vector que da como resultado un arreglo 
        unidimensional descrito en la siguiente fórmula:
        */

        int rowsNumber = 2;
        int colsNumber = 3;
        int[,] matrix = new int[rowsNumber, colsNumber];
        int[] vector = new int[rowsNumber];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Random.Range(minValue, maxValue);
            }
        }
        printIntMatrix(matrix);

        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = Random.Range(minValue, maxValue);
        }
        Debug.Log($"vector: [ {string.Join(", ", vector)} ]");


        int[] resultVector = new int[colsNumber];

        for (int i = 0; i < rowsNumber; i++)
        {
            for (int j = 0; j < colsNumber; j++)
            {
                resultVector[j] += matrix[i, j] * vector[i];
            }
        }
        Debug.Log($"resultVector: [ {string.Join(", ", resultVector)} ]");

        
    }

    void printIntMatrix(int[,] matrix)
    {
        string[] m = new string[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] row = new int[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                row[j] = matrix[i, j];
            }
            m[i] = $"[ {string.Join(", ", row)} ]";
        }
        Debug.Log($"[ {string.Join("\n", m)} ]");
    }

}
