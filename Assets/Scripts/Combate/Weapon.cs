using UnityEngine;
public abstract class Weapon
{
	//atributos da arma
	public string Name { get; private set; }
	public int Damage { get; protected set; }
	public char Rank { get; private set; }

	//construtor da arma
	public Weapon(string name, int damage)
	{
		Name = name;
		Damage = damage;
		Rank = GetRank(damage);
	}

	// implementação da afiação de arma
	public virtual void Sharpen()
	{
		Damage++;
		Debug.Log($"{Name} foi afiada! Dano Aumentou para{Damage}");

		var newRank = GetRank(Damage);
		if (newRank != Rank)
		{
			Rank = newRank;
			Debug.Log($"Rank da {Name} aumentou para {Rank}!");
		}
	}

	//classe abstrata da mecanica de Swing(balançar)
	public abstract int Swing();

	//implementação de rank da arma por dano
	public static char GetRank(int damage)
	{
		if (damage >= 10)
		{
			return 'S';
		}
		else if (damage >= 7)
		{
			return 'A';
		}
		else if (damage >= 4)
		{
			return 'B';
		}

		return 'C';
	}
}
