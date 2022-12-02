using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
			Translate(new Vector3(-CalculateRealSpeed(), 0f, 0f));
		}

		if (Input.GetKey(KeyCode.D))
		{
			Translate(new Vector3(CalculateRealSpeed(), 0f,0f));
		}

		if (Input.GetKey(KeyCode.W))
		{
			Translate(new Vector3(0f, CalculateRealSpeed(), 0f));
		}

		if (Input.GetKey(KeyCode.S))
		{
			Translate(new Vector3(0f, -CalculateRealSpeed(), 0f));
		}
	}

    void Translate(Vector3 translation) 
    {
		transform.position = transform.position + translation;
	}

    float CalculateRealSpeed() 
    {
        return speed / 100f;
    }
}
