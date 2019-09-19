using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeorgeCameraController : MonoBehaviour {

    public GameObject PlayerG;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - PlayerG.transform.position;
    }

    void LateUpdate()
    {
        transform.position = PlayerG.transform.position + offset;
    }

}
