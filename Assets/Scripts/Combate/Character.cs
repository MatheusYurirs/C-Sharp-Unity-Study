using UnityEngine;
public class Character
{
	public string Name { get; private set; }
	public int Life { get; private set; }
	public Weapon Weapon { get; private set; }

	public Armor Armor { get; private set; }

	public bool IsAlive { get => Life > 0; }

	//Construtor do personagem
	public Character(string name, int life, Weapon weapon, Armor armor)
	{
		Name = name;
		Life = life;
		Weapon = weapon;
		Armor = armor;
	}
	//mecanica de atacar o outro personagem
	public void Attack(Character other)
	{
		if (!CheckAlive()) return;

		if (!other.IsAlive)
		{
			Debug.Log($"{other.Name} Já está morto(a).");
			return;
		}

		if (!HasWeapon()) return;

		Debug.Log($"{Name} atacou {other.Name} com sua {Weapon.Name}.");
		Debug.Log($"Durabilidade da {other.Armor.Name} de {other.Name} é {other.Armor.Durability}, e Resistencia é {other.Armor.Resistence}");
		other.DealDamage(Weapon.Swing(), other.Armor.Resistence);
		other.ArmorDurability();
		if (other.Armor.ItsHaveDurability)
		{
			Debug.Log($"Durabilidade da Armadura de {other.Name} foi reduzida para {other.Armor.Durability}");
		}

	}
	//mecanica de afiar a arma
	public void SharpenWeapon()
	{
		if (!CheckAlive()) return;

		if (!HasWeapon()) return;

		Debug.Log($"{Name} afiou sua {Weapon.Name}");
		Weapon.Sharpen();

	}
	//desequipar a arma
	public void UnequipWeapon()
	{
		if (!CheckAlive()) return;

		if (!HasWeapon()) return;

		Debug.Log($"{Name} desequipou sua {Weapon.Name}");
		Weapon = null;
	}
	//equipar a arma
	public void EquipWeapon(Weapon weapon)
	{
		if (!CheckAlive()) return;

		if (Weapon != null)
		{
			Debug.Log($"{Name} já tem uma arma equipada.");
		}
		else
		{
			Weapon = weapon;

			Debug.Log($"{Name} equipou uma {Weapon.Name}(Dano: {Weapon.Damage} - Rank: {Weapon.Rank})");
		}
	}

	//desequipar a armadura
	public void UnequipArmor()
	{
		if (!CheckAlive()) return;

		if (!HasArmor()) return;

		Debug.Log($"{Armor.Name} foi desequipada");

		Armor = null;
	}

	//equipar a armadura
	public void EquipArmor(Armor armor)
	{
		if (!CheckAlive()) return;

		if (Armor != null)
		{
			Debug.Log($"{Name} já está com a uma armadura equipada");
		}
		else
		{
			Armor = armor;

			Debug.Log($"{Armor.Name} foi equipada");
		}

	}

	//verificar a durabilidade da arma
	private void ArmorDurability()
	{
		Armor.DurabilityReduce();
		Armor.ResistenceReduce();
	}
	//mecanica do dano tomado, se ele é reduzido pela armadura, 
	private void DealDamage(int ammountDmg, int ammountResist)
	{
		Life = Life - (ammountDmg - ammountResist);
		Debug.Log($"{Name} tomou {ammountDmg - ammountResist} de dano.\n" +

			$"Vida atual de {Name}: {Life}");

		CheckAlive();

	}

	//checar se o personagem está vivo
	private bool CheckAlive()
	{
		if (!IsAlive)
		{
			Debug.Log($"{Name} está morto.");
		}
		return IsAlive;
	}
	//chegar se o personagem está com uma arma
	private bool HasWeapon()
	{
		if (Weapon == null)
		{
			Debug.Log($"{Name} não tem uma arma.");
		}
		return Weapon != null;
	}
	//chegar se o personagem tem armadura
	private bool HasArmor()
	{
		if (Armor == null)
		{
			Debug.Log($"{Name} está sem armadura.");
		}
		return Armor != null;
	}
}
