using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakContinue : MonoBehaviour
{
    [SerializeField]
    int input;
    // Start is called before the first frame update
    void Start()
    {
        PrintPrimeNumbers(input);

	}


    int FindFirstDivisableNumber(int number)
    {
        int result = 2;

        while(result <= number) 
        {
            if (number % result == 0) 
            {
                break;
            }

            result++;   
        }

        return result;
    }

    void PrintPrimeNumbers(int number) 
    {
        for(int i = 2; i <= number; i++)
        {
            bool isPrimeNumber = true;

            for (int n = i / 2; n >= 2; n--) 
            {
                if (i % n == 0)
                {
                    isPrimeNumber = false;
                    continue;
                }

            }

            if(isPrimeNumber) 
            {
               Debug.Log(i);
            }
        }

    }
}
