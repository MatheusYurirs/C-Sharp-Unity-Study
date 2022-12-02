using UnityEngine;

public class Sword : Weapon
{
	public Sword() : base("Sword", 10) { }

	public Sword(int damage) : base("Sword", 10) { }

	//implementação da mecanica de swing(balançar) para a espada
	public override int Swing()
	{
		Debug.Log("Corta! Corta!");
		return Damage;
	}
	//afiação da espada
	public override void Sharpen()
	{
		Damage++;
		base.Sharpen();
	}
}
