using UnityEngine;

public class CharacterController : MonoBehaviour
{
	public float moveSpeed;

	public Move MoveComponent;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		PlayerControl();
	}


	void PlayerControl()
	{

		if (Input.GetKey(KeyCode.A))
		{
			MoveComponent.Speed1 = moveSpeed;
			MoveComponent.Direction1 = Vector3.left;
		}
		else if (Input.GetKey(KeyCode.D))
		{
			MoveComponent.Speed1 = moveSpeed;
			MoveComponent.Direction1 = Vector3.right;
		}
		else if (Input.GetKey(KeyCode.W))
		{
			MoveComponent.Speed1 = moveSpeed;
			MoveComponent.Direction1 = Vector3.up;
		}
		else if (Input.GetKey(KeyCode.S))
		{
			MoveComponent.Speed1 = moveSpeed;
			MoveComponent.Direction1 = Vector3.down;
		}
		else
		{
			MoveComponent.Speed1 = 0;
		}


	}
}
