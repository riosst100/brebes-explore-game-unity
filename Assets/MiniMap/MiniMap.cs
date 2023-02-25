using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Transform player;
    public float offset_y = 10f;

    void LateUpdate() 
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
        
        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.y = 0;
        eulerAngles.z = 0;
        transform.eulerAngles = eulerAngles;
    }
            
}
