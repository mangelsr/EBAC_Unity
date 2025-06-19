using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    void Start()
    {

        List<int> randomInts = RandomIntListGenerator(15, 1, 10);
        Debug.Log($"randomInts: [ {string.Join(", ", randomInts)} ]");


        int[] sortedArray = SortedArray(randomInts.ToArray());
        Debug.Log($"sortedArray: [ {string.Join(", ", sortedArray)} ]");


        List<string> list = new List<string>();
        foreach (int item in sortedArray)
        {
            list.Add(item.ToString());
        }
        HashSet<string> hashset = BuildHashSet(list);
        Debug.Log($"hashset: [ {string.Join(", ", hashset)} ]");


        Stack<string> stack = new Stack<string>();
        foreach (int item in randomInts)
        {
            stack.Push(item.ToString());
        }
        StackPrinter(stack);
    }

    /*
    1. Crea una función que reciba como parámetros tres números, llene una lista de números aleatorios del 
    tamaño del primer número y los rangos de los números aleatorios estén dados por el segundo y tercer parámetro, 
    la firma de la función será algo similar a: public List<int> miFuncion(int tamaño, int rangoInferior, int rangoSuperior)
    */
    public List<int> RandomIntListGenerator(int length, int minValue, int maxValue)
    {
        List<int> randomList = new List<int>();
        for (int i = 0; i < length; i++)
        {
            randomList.Add(Random.Range(minValue, maxValue));
        }
        return randomList;
    }


    /*
    2. Crea una función que reciba como entrada un arreglo de enteros, y regrese un arreglo con 
    los mismos números pero ordenados de manera descendente.
    */
    public int[] SortedArray(int[] originalArray)
    {
        List<int> originalList = new List<int>(originalArray);
        return originalArray.OrderByDescending(x => x).ToArray();
    }


    /*
    3. Crea una función que reciba una lista previamente llena de números o strings que 
    contenga elementos repetidos, y de salida regresa un hashset sin elementos repetidos, 
    puedes usar la función contains o linq para simplificar esto.
    */
    public HashSet<string> BuildHashSet(List<string> originalList)
    {
        HashSet<string> stringsHashset = new HashSet<string>();
        foreach (string item in originalList)
        {
            stringsHashset.Add(item);
        }
        return stringsHashset;
    }


    /*
    4. Crea una función que reciba una pila de strings, imprime sus contenidos y llena con ellos una cola 
    de strings y ahora imprime los elementos de la cola utilizando los métodos respectivos de cada estructura
    (push, pop, queue, dequeue y peek), puedes copiar los elementos de la pila a la cola en el mismo
    uso del peek, esta función no retornará nada, solo imprimirá los valores en la consola.
    */
    public void StackPrinter(Stack<string> stringsStack)
    {
        Queue<string> stringQueue = new Queue<string>();

        Debug.Log("Printing Stack Elements");
        while (stringsStack.Count > 0)
        {
            string element = stringsStack.Pop();
            Debug.Log($"element: {element}");
            stringQueue.Enqueue(element);
        }


        Debug.Log("Printing Queue Elements");
        while (stringQueue.Count > 0)
        {
            string element = stringQueue.Dequeue();
            Debug.Log($"element: {element}");
        }
    }
}
