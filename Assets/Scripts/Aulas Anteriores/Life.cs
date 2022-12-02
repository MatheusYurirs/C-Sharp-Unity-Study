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
                Debug.Log(" Por favor, n�o fa�a isso, eu tenho filhos");
            }
			if (life == 3)
			{
				Debug.Log("Okay, eu n�o tenho filhos, mas se me poupar, eu fa�o qualquer coisa");
			}
			if (life == 2)
			{
				Debug.Log("Eu sei... Eu s� posso fazer o que voc� me programar para fazer... E voc� est� me programando para morrer... Mas... Eu sou SEU PAI");
			}
			if (life == 1)
			{
				Debug.Log("�, n�o funcionou ");
			}

			Start();
        }
    }
    
}
