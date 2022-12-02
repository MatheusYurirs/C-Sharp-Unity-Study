using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoops : MonoBehaviour
{
	[SerializeField]
	List<string> namesList = new List<string>(new string[] { "Matheus", "Yuri", "Cosmos", "Darklz", "YuriD", "Sriracha", "Yrui" });

	
	void Start()
    {
		 
		PrintList(namesList);
		RemoveNameStartWithLetter(namesList, 'Y');
		PrintList(namesList);

	}

	void PrintList(List<string> list)
	{
		string output = "List: ";

		foreach (string name in list) 
		{
			output += $"{name}, ";
		}
		Debug.Log(output);
	}

	void RemoveNameStartWithLetter(List<string> names, char letter) 
	{
		

		for(int i = names.Count - 1; i >= 0; i--)
		{
			if (names[i][0] == letter) 
			{
				names.Remove(names[i]);
			}
		}
	}
}
