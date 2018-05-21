﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

	public GameObject Player;

	private Vector3 _offset;
	// Use this for initialization
	public void Start ()
	{
		_offset = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	public void LateUpdate ()
	{
		transform.position = Player.transform.position + _offset;
	}
}
