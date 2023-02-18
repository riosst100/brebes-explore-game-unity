using UnityEngine;
using TMPro;
using Mirror;
using System;

public class NetworkPing : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI pingText;

    private double ping;
    public Color color = new Color(0.2F, 0.3F, 0.4F);

    void Update()
    {
        // only while client is active
        if (!NetworkClient.active) return;

        if (pingText != null) {
            ping = Math.Round(NetworkTime.rtt * 1000);
            if (ping != 0) {
                pingText.text = ping + "ms";

                if (ping > 100) {
                    pingText.color = color;
                } else {
                    pingText.color = Color.white;
                }
            }
        }
    }
}
