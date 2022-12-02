using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structs : MonoBehaviour
{
    [Serializable]
    struct PlayerData
    {
        public int Health;
        public int Score;
        public string Name;
        public int[] Status;
        public Coordinates Coordinates;
        public PlayerState PlayerState;
    }

    [Serializable]
    struct Coordinates
    {
       public int x;
       public int y;
    }

    enum PlayerState
    {
        Alive,
        Dead
    }

    [SerializeField]
    PlayerData[]  playerdata;

    void Start()
    {
        PlayerData lexData = new PlayerData
        {
            Name = "Lex",
            Health = 0,
            Score = 0,
            Coordinates = new Coordinates 
            {
                x = 1,
                y = 2
            },
            PlayerState= PlayerState.Alive,
            Status =  new int[5]
        };

    }

   
}
