using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
	public float speed;	
	private Rigidbody rb;
	private int count;
	public Text countText;
	public Text winText;
	

	void setCount()
	{
		countText.text = "Count: " + count.ToString();
	}
	
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		setCount();
		winText.text = "";
	}	    

	// FixedUpdate is called before performing any physics computations
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.CompareTag("pickUp"))
		{
			++count;
			setCount();
			other.gameObject.SetActive(false);
			if(count >= 5)
				winText.text = "You won!";
		}
    }
}