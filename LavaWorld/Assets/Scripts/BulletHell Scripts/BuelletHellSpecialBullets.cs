﻿using UnityEngine;
using System.Collections;
/// <summary>
/// behavior of special bullets /// think this may be a duplicate class somehwre - created it as  aq uick fix  
/// </summary>
public class BuelletHellSpecialBullets : MonoBehaviour {

	// Use this for initialization

	// Use this for initialization
	//public int speed =9;
public Rigidbody2D myegd;
	// Use this for initialization
	void Start () {
	myegd = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

	//myegd.AddForce(Vector3.forward * speed);
		
		myegd.velocity = transform.TransformDirection(Vector3.up * 15);
		myegd.AddForce(myegd.transform.up * 10);	}
}



