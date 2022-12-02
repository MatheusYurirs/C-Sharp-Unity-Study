using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    int life = 5;
    
    // Start is called before the first frame update
    void Start()
    {
		Debug.Log($"Cubo's Life: { life }");
	}

    // Update is called once per frame
    void Update()
    {
        
        HitKill();
		HitDmg();
	}


    void HitKill() 
    {
        if (life <= 0)
        {
            
            Debug.Log("Cubo is dead");
            Destroy(this.gameObject);
        }
    }

    void HitDmg() 
    {
        if(Input.GetKeyUp(KeyCode.Space)) 
        {
            life--;
            if (life == 4)
            {
                Debug.Log(" Por favor, não faça isso, eu tenho filhos");
            }
			if (life == 3)
			{
				Debug.Log("Okay, eu não tenho filhos, mas se me poupar, eu faço qualquer coisa");
			}
			if (life == 2)
			{
				Debug.Log("Eu sei... Eu só posso fazer o que você me programar para fazer... E você está me programando para morrer... Mas... Eu sou SEU PAI");
			}
			if (life == 1)
			{
				Debug.Log("É, não funcionou ");
			}

			Start();
        }
    }
    
}
