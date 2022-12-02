

using UnityEngine;

public class Orc : Character
{
	public Orc(Weapon weapon, Armor armor) : base("Yuri", 150, "Orc", weapon, armor) { }

	public override int Passive()
	{
		Debug.Log("A passiva do Orc é sua vida maior");
		return 0;
	}

}
