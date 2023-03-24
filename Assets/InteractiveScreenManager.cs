using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Mirror;

public class InteractiveScreenManager : NetworkBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;

    private Renderer _videoRenderer;

    [SyncVar(hook = nameof(SetStartFrame))]
    private long _frame = 0;

    void Awake() 
    {
        _videoRenderer = _videoPlayer.GetComponent<Renderer>();
    }

    public override void OnStartServer() 
    {
        if (!isServer) return;

        base.OnStartServer();

        _videoPlayer.Play();

        _frame = 0;
    }

    private void Update() 
    {
        if (!isServer) return;

        long currentFrame = _videoPlayer.frame;

        long lastFrame = (long)_videoPlayer.frameCount;

        if (currentFrame >= 0) {

            Debug.Log("currentFrame: "+currentFrame);

            if (currentFrame >= lastFrame-2) {
                // Change texture shader
                _videoRenderer.material.shader = Shader.Find("Universal Render Pipeline/Lit");
            } else if (currentFrame > 0) {
                if (_videoRenderer.material.shader == Shader.Find("Universal Render Pipeline/Lit")) {
                    _videoRenderer.material.shader = Shader.Find("Unlit/Texture");
                }
            }

            if (currentFrame >= lastFrame-1) {
                _videoPlayer.Stop();

                currentFrame = -1;
            }
            
            _frame = currentFrame;
        }
    }

    private void SetStartFrame(long oldFrame, long newFrame) 
    {
        long lastFrame = (long)_videoPlayer.frameCount;

        if (_videoPlayer.frame <= 0) {
            _videoPlayer.frame = newFrame;

            _videoPlayer.Play();
        }

        Debug.Log("newFrame: "+newFrame);
        Debug.Log("lastFrame: "+(lastFrame-2));

        if (newFrame >= lastFrame-2) {
            // Change texture shader
            _videoRenderer.material.shader = Shader.Find("Universal Render Pipeline/Lit");
        } else if (newFrame > 2){
            if (_videoRenderer.material.shader == Shader.Find("Universal Render Pipeline/Lit")) {
                _videoRenderer.material.shader = Shader.Find("Unlit/Texture");
            }
        }

        // Debug.Log("newFrame: "+newFrame);
        // Debug.Log("frameCount: "+(long)_videoPlayer.frameCount)

        if (newFrame < 0) {
            _videoPlayer.Stop();
        }
    }
}
