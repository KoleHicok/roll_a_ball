using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarsonCameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
        Debug.Log(offset);
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
