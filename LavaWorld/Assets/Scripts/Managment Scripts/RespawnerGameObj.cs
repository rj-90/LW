﻿using UnityEngine;
using System.Collections;

public class RespawnerGameObj : MonoBehaviour {
/// <summary>
/// returns gameobject this script is attacjed to to their origitanl state 
///have o hange code that 'destroys them' into code that deactivates them... -> check other files to fix this
/// </summary>
Vector3 iniitalPostion;
Quaternion initialRotation;
Vector3 intialScale;
Rigidbody2D initialRidgidbody;

	SpriteRenderer myImg;
	Color originalColor;
//GameObject instance;

	// Use this for initialization
	void Start () {
	//instance = GetComponent<GameObject>();

//	if(this.isActiveAndEnabled== true){
//	gameObject.SetActive(false);
//
//	}
	iniitalPostion = transform.position;
	initialRotation = transform.rotation;
	intialScale = transform.localScale;


	myImg = GetComponent<SpriteRenderer>();
	originalColor = myImg.color;

	if(gameObject.GetComponent<Rigidbody2D>()!=null){

	initialRidgidbody = GetComponent<Rigidbody2D>();
	}

	}
	


	public void ResetDefaultpostions(){

	transform.position = iniitalPostion;
		transform.rotation =initialRotation;
	transform.localScale = intialScale;
		myImg.color = originalColor ;


		if(initialRidgidbody!=null){

			initialRidgidbody.velocity= Vector3.zero;
		}
	}

	///CHECK HOW THIS IS USED before if i used this script with naything that resets values if not use below method 
	void OnBecameInvisible(){

		//StartCoroutine("DelayRespawn");
		Invoke("DelayRespawn",0.5f);
		//ResetDefaultpostions();
	}

	void DelayRespawn(){
		ResetDefaultpostions();
	}

//	IEnumerator DelayRespawn(){
//
//		yield return new WaitForSeconds(5f);
//		ResetDefaultpostions();
//
//
//	}


}
