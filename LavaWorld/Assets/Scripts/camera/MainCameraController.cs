﻿using UnityEngine;
using System.Collections;

public class MainCameraController : MonoBehaviour {

	// Use this for initialization
   //public Vector3 postionI; 
   //public Vector3 targetPos;
   public GameObject PlayerPosition;
   PlayerController playerdirection;
   public Vector3 targetlocation;
   public float smoothing = 0;
   public float xVal, Yval;
	float xPosition, yPosition, zPosition;

   void Start()
   {
       PlayerPosition = GameObject.FindGameObjectWithTag("Player");
       playerdirection = PlayerPosition.GetComponent<PlayerController>();
		//PlayerPosition = PlayerPosition.GetComponent<GameObject>();
   }
   /// <summary>
   /// do you guys want this script - just adds space infront of the player - or we can manually go and change the x value and just have lerp here - notetoself
   /// </summary>

   // Update is called once per frame
   void FixedUpdate()
   {//// if our camera is not a child we can implement ths not oto show the flow but we habe tp scale it right amd this will save the y pos of the camera 
    ///right not its relative to the player 

	targetlocation = new Vector3(PlayerPosition.transform.position.x, PlayerPosition.transform.position.y, transform.position.z);
		//targetlocation = PlayerPosition.transform.position;
       if (playerdirection.isFacingRight)
       {
          //transform.position 
           targetlocation = new Vector3(PlayerPosition.transform.position.x + xVal, PlayerPosition.transform.position.y + Yval, transform.position.z);
           transform.position = Vector3.Lerp(transform.position, targetlocation, smoothing * Time.deltaTime);
       }
       else if (!playerdirection.isFacingRight)
       {
			targetlocation = new Vector3(PlayerPosition.transform.position.x - xVal, PlayerPosition.transform.position.y+Yval, transform.position.z);
         transform.position = Vector3.Lerp(transform.position, targetlocation, smoothing * Time.deltaTime);
       }
         xPosition = PlayerPosition.transform.position.x;
		yPosition = PlayerPosition.transform.position.y;
		 zPosition = transform.position.z;
         //transform.position 
         if (PlayerPosition.transform.position.x > 100 || PlayerPosition.transform.position.x < 0)
         {
             xPosition = targetlocation.x;
         }
         if (PlayerPosition.transform.position.y > 100 || PlayerPosition.transform.position.y < -100)
         {
             yPosition = targetlocation.y;
         }
         else {
			xPosition = PlayerPosition.transform.position.x;
			yPosition = PlayerPosition.transform.position.y;


         }
         targetlocation = new Vector3(xPosition, yPosition, zPosition);


         transform.position = Vector3.Lerp(transform.position, targetlocation, 10f * Time.deltaTime); 
   }
}

