using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using StarterAssets;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(StarterAssetsInputs))]
public class ServerManagement : MonoBehaviour
{
    NetworkManager manager;
    StarterAssetsInputs _input;

    void Awake()
    {
        manager = GetComponent<NetworkManager>();
        _input = GetComponent<StarterAssetsInputs>();
    }
    
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
        if (!NetworkClient.active)
        {
            manager.StartClient();
        }
    }

    private void Update()
    {
        BackToLobby();
    }   

    private void BackToLobby() 
    {
        if (_input.leave) {
            manager.StopClient();
            SceneManager.LoadScene("MainMenu");
        }
    }
}
