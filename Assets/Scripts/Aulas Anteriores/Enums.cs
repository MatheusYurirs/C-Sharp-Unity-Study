using UnityEngine;

public class Enums : MonoBehaviour
{

	enum GameState
	{
		Starting,
		InGame,
		GameOver
	}

	[SerializeField]
	GameState gameState;

	[SerializeField]
	int value;

	[SerializeField]
	string Name;
	void Start()
	{

		switch (gameState)
		{
			case GameState.Starting:
				Debug.Log("Game is Starting");
				break;

			case GameState.InGame:
				Debug.Log("In Game");

				break;

			case GameState.GameOver:
				Debug.Log("Game Over");
				break;

		}

	}


}
