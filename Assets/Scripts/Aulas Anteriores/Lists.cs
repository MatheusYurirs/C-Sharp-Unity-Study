using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    [SerializeField]
    string input;

    // Start is called before the first frame update
    void Start()
    {
        IsPalindrome(input);
	}

    void PrintList(List<int> list) 
    {
        string output = "List: ";

        for (int i = 0; i < list.Count; i++)
        {
            output += $"{list[i]}, ";
        }

        Debug.Log(output);
    }

    bool IsPalindrome(string word) 
    {
		// [0][1][2][3][4][5]
		//        |
        // 6/2 = 3 
		//
		// [0][1][2][3][4]
		//     |
		// 5/2 = 2
		//

		for (int i = 0; i < word.Length / 2; i++) 
        {
            if (word[i] != word[word.Length - 1 - i]) 
            {
                Debug.Log($"{word} is not a Palindrome.");
                return false;
            }
            
        }

        Debug.Log($"{word} is a Palindrome.");
        return true;
    }
}
