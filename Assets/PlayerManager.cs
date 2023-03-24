using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using TMPro;
using kcp2k;
using StarterAssets;

public class PlayerManager : NetworkBehaviour
{
    [SerializeField]
    private TextMeshProUGUI playerNumberText;

    [SyncVar]
    private int playersConnected = 0;

    // public PlayerManager Instance; // Quick and dirty singleton, you can find better implementations later
    public List<ThirdPersonController> players = new List<ThirdPersonController>();

    private void Update() 
    {
        if (isServer) {
            playersConnected = NetworkServer.connections.Count;
        }

        playerNumberText.text = playersConnected + " online";
    }

    // public void Awake()
    // {
    //     Instance = this;
    // }

    // Call this when you want to change a players name
    public void SetPlayerName(int playerId, string name)
    {
        Debug.Log("MASUK PLAYER MANAGER: "+playerId+" dan name: "+name);
        CmdSetPlayerName(playerId, name);
    }

    // Tell server name to let people know a name has changed
    [Command]
    private void CmdSetPlayerName(int playerId, string name)
    {
        if (!isOwned) { return; }
        
        Debug.Log("MASUK CmdSetPlayerName: "+playerId+" dan name: "+name);
        players[playerId].SetPlayerName(name); // update my player name value
        RpcSetPlayerName(playerId, name); // tell clients to update value
    }

    // tell client to update their own copy of the players name
    [ClientRpc]
    private void RpcSetPlayerName(int playerId, string name)
    {
        players[playerId].SetPlayerName(name); // update my player name value
    }
}
