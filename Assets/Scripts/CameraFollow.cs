using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    void Start()
    {
                
    }

    void LateUpdate()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, Time.deltaTime);
        gameObject.transform.position = new Vector3(0, player.transform.position.y, -10);
    }
}
