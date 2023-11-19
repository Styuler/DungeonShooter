using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    public float smoothing;
    [SerializeField] private Vector3 offset;

    private void FixedUpdate()
    {
        if (player != null)
        {
            Vector3 newPosition = Vector3.Lerp(transform.position, player.transform.position + offset, smoothing);
            transform.position = newPosition;
        }
    }
}
