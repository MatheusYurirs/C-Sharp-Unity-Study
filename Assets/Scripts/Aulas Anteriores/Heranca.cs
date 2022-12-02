using System.Collections.Generic;
using UnityEngine;

public class Heranca : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		//Animal myAnimal = new Animal();
		Animal myCat = new Cat();
		Animal myDog = new Dog();

		List<Animal> myAnimals = new List<Animal>()
		{
			//myAnimal,
			myCat,
			myDog
		};

		foreach (var animal in myAnimals)
		{
			animal.AnimalSound();
			animal.Sleep();
		}
	}

}

abstract class Animal
{
	public abstract void AnimalSound();

	public void Sleep()
	{
		Debug.Log("Zzzz");
	}
}

class Cat : Animal
{
	public override void AnimalSound()
	{
		Debug.Log("O gato diz: MIAAAAAAUU");
	}
}

class Dog : Animal
{
	public override void AnimalSound()
	{
		Debug.Log("O cachorro diz: AAAAAAAAAAAAAAAU");
	}
}
