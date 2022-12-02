using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTerrain : MonoBehaviour
{
    [SerializeField]
    GameObject cubePrefab;

    [SerializeField]
    int terrainSize;

    [SerializeField]
    int wallSize;
   
    List<GameObject> allCubes = new List<GameObject>();

    void Start()
    {
        for (int column = 0; column < terrainSize; column++)
        {
            for (int line = 0; line < terrainSize; line++)
            {
				int randomHeight = Random.Range(1, 5);

                for (int height = 0; height < randomHeight; height++) 
                {
					allCubes.Add(Instantiate(cubePrefab, new Vector3(line, height, column ), Quaternion.identity));

					if (column == 0 || line == 0 || column == terrainSize - 1 || line == terrainSize - 1)
					{
                        for (height = 0; height < wallSize; height++)
                        {
							allCubes.Add( Instantiate(cubePrefab, new Vector3(line, height + 1, column), Quaternion.identity));
                        }
					}
				}
            }
        }
    }
	void Update()
	{
		RemoveHighWall();
	}

    void RemoveHighWall() 
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (wallSize < 0) return;

			for (int i = allCubes.Count - 1; i >= 0; i--)
			{
				if (allCubes[i].transform.position.y == wallSize)
				{
					Destroy(allCubes[i]);
					allCubes.Remove(allCubes[i]);
				}
			}
			wallSize--;
		}
	}
}
