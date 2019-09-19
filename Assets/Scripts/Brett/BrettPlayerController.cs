using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BrettPlayerController : MonoBehaviour
{
	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;
	Vector3 startingPosition;
	Transform cachedTransform;


	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		winText.text = "";
		cachedTransform = transform;
		startingPosition = cachedTransform.position;
	}
	private void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);

		if (cachedTransform.position.y < -5)
		{
			cachedTransform.position = startingPosition;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive(false);
			count += 1;
			SetCountText();
		}

		if (other.gameObject.CompareTag("Pick Up 2"))
		{
			other.gameObject.SetActive(false);
			count += 2;
			SetCountText();
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString();
		if (count >= 1)
		{
			winText.text = "You Win!";
			SceneManager.LoadScene(sceneName: "JesseScene");
		}
	}
}
