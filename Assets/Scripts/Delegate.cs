using System;
using UnityEngine;



public class Delegate : MonoBehaviour
{
	private Class _myClass;

	Action<int> _simpleDelegate;

	private event Action _simpleDelegateEvent;
	void Start()
	{
		_simpleDelegate = Method;
		_myClass = new Class();

		_myClass.MyEvent += SimpleMethod1EventHandler;
		_myClass.MyEvent += SimpleMethod2EventHandler;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			_myClass.DoStuff(1);
		}
	}

	private void SimpleMethod1EventHandler()
	{
		Debug.Log("My Simple method 1.");
	}

	private void SimpleMethod2EventHandler()
	{
		Debug.Log("My Simple method 2.");
	}

	private void Method(int a)
	{

	}
}

class Class
{
	public event Action MyEvent;

	public void SimpleMethod()
	{
		Debug.Log("Simple method in Class");
	}

	public string DoStuff(int a)
	{
		MyEvent?.Invoke();
		a++;
		Debug.Log($"DoStuff({a}) da Classe");
		return a.ToString();
	}
}