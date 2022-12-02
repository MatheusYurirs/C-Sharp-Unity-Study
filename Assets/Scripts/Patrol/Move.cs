using UnityEngine;

public class Move : MonoBehaviour
{
	//Movimentação básica, speed = velocidade do objeto
	float Speed;

	//variavel Direction que é do tipo vector3
	Vector3 Direction;

	public float Speed1 { get => Speed; set => Speed = value; }
	public Vector3 Direction1 { get => Direction; set => Direction = value; }

	private void Update()
	{
		Translate(Direction * Speed * Time.deltaTime);
	}
	public void Translate(Vector3 translation)
	{
		transform.position = transform.position + translation;
	}
}
