﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
	public GameObject player;
	
	private Vector3 offset;
	
	// Start is called before the first frame update
    	void Start()
    	{
        	offset = transform.position - player.transform.position;
    	}

    	// Update is called once per frame, but guaranteed to run post processing of all computations of the player object
    	void LateUpdate()
    	{
        	transform.position = player.transform.position + offset;
    	}
}