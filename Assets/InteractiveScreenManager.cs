using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Mirror;

public class InteractiveScreenManager : NetworkBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;

    [SyncVar(hook = nameof(SetStartFrame))]
    private long _frame = 0;

    private void Update() 
    {
        if (!isServer) return;
        
        _frame = _videoPlayer.frame;
    }

    private void SetStartFrame(long oldFrame, long newFrame) 
    {
        if (_videoPlayer.frame <= 0) {
            _videoPlayer.frame = newFrame;
        }
    }
}
