using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Mirror;

public class CustomNetworkManager : NetworkManager
{
    public PlayerManager _playerManager;

    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);

        int playerId = _playerManager.players.Count() + 1;
        string name = "car_" + playerId.ToString();
        _playerManager.SetPlayerName(playerId, name);

        Debug.Log("SPAWN: "+playerId+" dan name: "+name);
    }
}
