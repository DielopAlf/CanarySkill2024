using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataScript : MonoBehaviour
{
    public static PlayerData[] players;
    public void Multiplayer()
    {
        players = new PlayerData[PlayerPrefs.GetInt("jugadores")];
    }

}
public class PlayerData
{
    public string playername;

    public PlayerData(string name)
    {
        playername = name;
    }
}