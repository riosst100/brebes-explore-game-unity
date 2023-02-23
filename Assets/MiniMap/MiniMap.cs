using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Transform player;

    void LateUpdate() 
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
        // transform.rotation = Quaternion.Euler(0,0,0);
        // Debug.Log("ROT: "+transform.rotation);
    }
}
