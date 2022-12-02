using UnityEngine;

public class Elf : Character
{
	public float HealChance { get; private set; }
	public Elf(Weapon weapon, Armor armor, float healChance) : base("Legoas", 90, "Elfo", weapon, armor)
	{
		HealChance = healChance;
	}

	public Elf(int life, float healChance) : base("Legoas", life, "Elfo")
	{
		HealChance = healChance;
	}

	public override int Passive()
	{
		int heal = 0;

		if (Random.Range(0f, 1f) < HealChance)
		{
			Debug.Log($"Passiva ativada, você curou {20} de vida");
			heal = heal + 20;
		}

		return heal;
	}
}
