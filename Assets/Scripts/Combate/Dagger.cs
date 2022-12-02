using UnityEngine;

public class Dagger : Weapon
{
	//variavel da mecanica de critico
	public float CritChance { get; private set; }

	//construtor da mecanica de critico
	public Dagger(float critChance) : base("Dagger", 8)
	{
		CritChance = critChance;
	}
	//construto da adaga
	public Dagger(int damage, float critChance) : base("Dagger", damage)
	{
		CritChance = critChance;
	}

	//implementação da classe de swing(balançar) para a adaga
	public override int Swing()
	{
		Debug.Log("Fura! Fura!");

		var finalDamage = Damage;
		//mecanica de randomização do crítico por chance ce crítico
		if (Random.Range(0f, 1f) < CritChance)
		{
			Debug.Log("Critical Hit");
			finalDamage *= 3;
		}

		return finalDamage;
	}
}