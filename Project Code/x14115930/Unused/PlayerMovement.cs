using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 6f;

	Vector3 movement;
	Animator anim;
	Rigidbody playerRigidBody;
	int floorMask;
//	float camRayLength = 100f;

	void Awake(){
		floorMask = LayerMask.GetMask ("Floor");
		anim = GetComponent<Animator> ();
		playerRigidBody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate(){
		//float h = Input.GetAxisRaw ("Horizontal");
		//float v = Input.GetAxisRaw ("Vertical");
		//Move (h, v);
		//Turning ();
	//	Animating (h, v);
	}

	void Move(float h, float v){
		movement.Set (h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
		playerRigidBody.MovePosition (transform.position + movement);
	}

	void Turning(){
//		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		//RaycastHit floorHit;
	//	if(Physics.Raycast (camRay, out floorHit, camRayLength, floorMask)){
//			Vector3 playerToMouse = floorHit.point - transform.position;
	//		playerToMouse.y = 0f;
//			Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
		//	playerRigidBody.MovePosition (transform.position + movement);
		//}
	}

	//void Animating(float h, float v){
		//bool walking = v > 0f;
		//bool walkingBackwards = v < 0f;
		///bool walkingLeft = h < 0f;
		//bool walkingRight = h >0f;
		///anim.SetBool ("IsMoving", walking);
		///anim.SetBool ("IsMovingBack", walkingBackwards);
		///anim.SetBool ("IsMovingRight", walkingRight);
		//anim.SetBool ("IsMovingLeft", walkingLeft);
	//}

}
