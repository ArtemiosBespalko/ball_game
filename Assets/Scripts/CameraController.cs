using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 _offset;

    public void Start()
    {
        _offset = transform.position - player.transform.position;
    }

    public void LateUpdate()
    {
        transform.position = player.transform.position + _offset;
    }
}
