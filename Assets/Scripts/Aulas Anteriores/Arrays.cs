using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    [SerializeField]
	string[] stringArray = new string[] { "Matheus", "Yuri", "Cosmos", "Darklz", "YuriD", "Sriracha", "Yrui" };
	
    [SerializeField]
	int[] initializedArray;
    
    
	void Start()
    { 
        PrintArray(initializedArray);
		Shuffle(initializedArray);
		PrintArray(initializedArray);
    }

	void Shuffle(int[] intArray) 
	{
		for (int i = 0; i < intArray.Length - 2; i++) 
		{
			int shuffleIndex = Random.Range(i, intArray.Length);

			if (shuffleIndex == i) continue;

			Swap(intArray, i, shuffleIndex);
		}
	}

	void Swap(int[] intArray, int index1, int index2) 
	{
		int aux = intArray[index1];
		intArray[index1] = intArray[index2];
		intArray[index2] = aux;
	}

	int FindGreatest(int[] values) 
	{
		int greatestValue = int.MinValue;

		for (int i = 0; i < values.Length; i++) 
		{
			if (values[i] > greatestValue) 
			{
				greatestValue = values[i];
			}
		}

		return greatestValue;
	}


    void PrintArray(int[] intArray) 
    {
        string output = "Array: ";

        for (int i = 0; i < intArray.Length; i++) 
        {
            output += $"{intArray[i]}, ";
            
        }

		Debug.Log(output);
	}

	void PrintArray(string[] stringArray)
	{
		string output = "Array: ";

		for (int i = 0; i < stringArray.Length; i++)
		{
			output += $"{stringArray[i]}, ";

		}

		Debug.Log(output);
	}

	
}
