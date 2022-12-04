using System.Collections.Generic;
using UnityEngine;




public class VehicleProgram : MonoBehaviour
{
	delegate void StartEngine();
	// Start is called before the first frame update
	private void Start()
	{
		List<StartEngine> starters = new List<StartEngine>();

		var car = new Car();
		var motorcycle = new MotorCycle();
		var airplane = new Airplane();

		starters.Add(car.StartCar);
		starters.Add(motorcycle.StartMotorCycle);
		starters.Add(airplane.StartAirplane);

		foreach (var starter in starters)
		{
			starter.Invoke();
		}
	}

	// Update is called once per frame
	void Update()
	{

	}

	class Car
	{
		public void StartCar()
		{
			Debug.Log("Starting my car");
		}
	}

	class MotorCycle
	{
		public void StartMotorCycle()
		{
			Debug.Log("Starting my motorcycle");
		}
	}
	class Airplane
	{
		public void StartAirplane()
		{
			Debug.Log("Starting my Ariplane");
		}
	}
}
