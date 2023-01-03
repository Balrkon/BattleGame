using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerNetwork : NetworkBehaviour {

	private void Update(){

        if (!IsOwner) return;
        
        Vector3 moveDir = new Vector3(0, 0, 0);
        float movementSpeed = 3f;

	    if (Input.GetKey(KeyCode.W)) moveDir.z = (+1f) * movementSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S)) moveDir.z = (-1f) * movementSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) moveDir.x = (-1f) * movementSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) moveDir.x = (+1f) * movementSpeed * Time.deltaTime;

        //update the position
        transform.position += moveDir;

        //update the position
        //transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);



        //output to log the position change
        //Debug.Log(transform.position);

	}   

}
