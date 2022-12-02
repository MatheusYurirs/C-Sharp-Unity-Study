using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool result = !true;

        result = true & true;
        result = true | true;
        result = true ^ true;
        result = true && true;
        result = true || true;
        Debug.Log(result);
    }

}
