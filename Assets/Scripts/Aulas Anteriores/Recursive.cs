using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recursive : MonoBehaviour
{
    [SerializeField] int fac;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(Factorial(fac));
    }

    int Factorial(int value) 
    {
        if (value == 0) return 1;

        return value * Factorial(value - 1);
    }   
}
