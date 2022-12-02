using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    [SerializeField]float nota1;
    [SerializeField]float nota2;

    // Start is called before the first frame update
    void Start()
    {

		Debug.Log("Media: " + CalculaMedia(nota1, nota2));

	}

	float CalculaMedia(float nota_1, float nota_2)
	{
		float cMedia = (nota_1 + nota_2) / 2;

		if (cMedia >= 5)
		{
			Debug.Log("Aluno passou");

		}
		else
		{
			Debug.Log("Aluno Reprovou");
		}
		return cMedia;

	}

	


}
