using UnityEngine;
public class Armor
{
	public string Name { get; private set; }

	public int Durability { get; private set; }

	public int Resistence { get; private set; }

	public bool ItsHaveDurability { get => Durability > 0; }

	public Armor(string name, int durability, int resistence)
	{
		Name = name;
		Durability = durability;
		Resistence = resistence;
	}

	public void DurabilityReduce()
	{
		if (!CheckDurability()) return;
		Durability--;
	}

	public void ResistenceReduce()
	{
		if (Durability == 0)
		{
			Resistence = 0;
		}
	}

	private bool CheckDurability()
	{
		if (!ItsHaveDurability)
		{
			Debug.Log($"{Name} não tem mais durabilidade.");

		}

		return ItsHaveDurability;
	}

}