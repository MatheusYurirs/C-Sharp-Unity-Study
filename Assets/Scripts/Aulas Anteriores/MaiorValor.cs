using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaiorValor : MonoBehaviour
{
    [SerializeField]int a, b, c;

    // Start is called before the first frame update
    void Start()
    {
        if (a > b && a > c)
        {
            Debug.Log($"NumeroOpt1: {a} ");
        }
        else if (b > c)
        {
            Debug.Log($"NumeroOpt2: {b} ");
        }
        else
        {
            Debug.Log($"NumeroOpt3: {c} ");
        }
       
    }

}
