﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EmmyPlayerControl : MonoBehaviour
{
    public Text countText;
    public Text winText;

    public float speed;
    private Rigidbody rb;
    private int count;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement* speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadSceneAsync("BrettScene");
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 1)
        {
            winText.text = "You Win!";
            Invoke("ChangeScene", 1f);
        }
    }

}
