using UnityEngine;
public class Combat : MonoBehaviour
{
	private Character _player1;
	private Character _player2;
	void Start()
	{
		var sword = new Sword();
		var armor = new Armor("Armor", 3, 4);
		_player1 = new Character("Yuri", 100, sword, armor);

		//0.1 é o mesmo que 10%, somente a adaga possui crítico
		var dagger = new Dagger(0.1f);
		var armor2 = new Armor("Armor", 6, 2);
		_player2 = new Character("Sonic", 90, dagger, armor2);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			_player1.Attack(_player2);
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			_player1.SharpenWeapon();
		}

		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			_player1.UnequipWeapon();
		}

		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			_player1.EquipWeapon(GetRandomWeapon());
		}

		if (Input.GetKeyDown(KeyCode.Alpha5))
		{
			_player1.UnequipArmor();
		}
		if (Input.GetKeyDown(KeyCode.Alpha6))
		{
			_player1.EquipArmor(new Armor("ArmaduraPesada", Random.Range(2, 5), Random.Range(3, 7)));
		}


		if (Input.GetKeyDown(KeyCode.Q))
		{
			_player2.Attack(_player1);
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			_player2.SharpenWeapon();
		}


		if (Input.GetKeyDown(KeyCode.E))
		{
			_player2.UnequipWeapon();
		}

		if (Input.GetKeyDown(KeyCode.R))
		{
			_player2.EquipWeapon(GetRandomWeapon());
		}

		if (Input.GetKeyDown(KeyCode.T))
		{
			_player2.UnequipArmor();
		}
		if (Input.GetKeyDown(KeyCode.Y))
		{
			_player2.EquipArmor(new Armor("ArmaduraLeve", Random.Range(2, 6), Random.Range(1, 4)));
		}

	}

	//Método que sorteia arma aleatória
	private Weapon GetRandomWeapon()
	{
		var randomWeapon = Random.Range(0, 2);

		switch (randomWeapon)
		{
			default:
			case 0:
				return new Sword();

			case 1:
				return new Dagger(0.1f);
		}
	}
}
