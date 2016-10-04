using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	public float inputDelay = 0.1f; //User can set if they want a delay when they press an input key.
	public float forwardVelocity = 12; //User can set the forwards velocity.
	public float rotateVelocity = 100; //User can set the turning velocity.
	public float strafeVelocity = 100; //User can set the starfe velocity.
	Animator anim;
	Animation forward;
	Animation backwards;
	Animation left;
	Animation right;
	Animation idle;
	GameObject Player;



	Vector3 strafe; //Declares variable for use in the Strafe function.

	Quaternion targetRotation; //Stores rotations.
	Rigidbody rBody; //Stores the player's RigidBody component.
	float forwardInput, turnInput, strafeInput; //Declares variables that store user input.
	//float h;
	//float v;

	public Quaternion TargetRotation { //Sends the players rotations to the CameraController script.
		get { return targetRotation; } //Camera rotations based on player rotations.
	}

	void Start(){
		targetRotation = transform.rotation; //Sets target.
		if (GetComponent<Rigidbody> ()){ //If statement to check if there is a Rigidbody.
			rBody = GetComponent<Rigidbody> (); //Gets Rigidbody.
		}
		else {
			Debug.LogError ("The character does not have a Rigidbody."); //If there is no Rigidbody then this message is sent to the user.
		}
		forwardInput = turnInput = strafeInput = 0; //Sets the starting inputs to 0.

		//anim = GetComponent<"playerAC">;


	}

	void GetInput(){ //This function gets all the input that is needed to move the player.
		forwardInput = Input.GetAxis("Vertical"); //Vertical input from up and down keys.
		turnInput = Input.GetAxis("Mouse X"); //X axis turning input from mouse.
		strafeInput = Input.GetAxis("Horizontal"); //Horizontal input from the left and right keys.
	}

	void Update(){
		GetInput ();
		Turn ();
		/*
		if (Input.GetKey (KeyCode.W)) {
			Player.GetComponent<Animation>().Play("Run Firing");
		} else if (Input.GetKey (KeyCode.S)) {
			Player.GetComponent<Animation>().Play("Run_backwards"); 
		} else if (Input.GetKey (KeyCode.A)) {
			Player.GetComponent<Animation>().Play("Left Fire");
		} else if (Input.GetKey (KeyCode.D)) {
			Player.GetComponent<Animation>().Play("Right FIre");
		}
		else
		{
			Player.GetComponent<Animation>().Play("Idle Aim");
		}*/



	}

	void FixedUpdate(){
		Run ();
		Strafe ();
		//Animating (h, v);
	}

	void Run(){ //Function makes the player move forwards and backwards.
		if (Mathf.Abs (forwardInput) > inputDelay) { //Moves.
			rBody.velocity = transform.forward * forwardInput * forwardVelocity;
		}
		else //Velocity is 0.
			rBody.velocity = Vector3.zero;
	}

	void Strafe(){ //Function makes the player strafe from side to side.
		float h = strafeInput;
		strafe.Set (h, 0f, 0f);
		strafe = targetRotation * strafe.normalized * strafeVelocity * Time.deltaTime;
		rBody.MovePosition (transform.position + strafe);
	}

	void Turn(){ //Function allows the user to turn the player with the mouse.
		if (Mathf.Abs (turnInput) > inputDelay) {
			targetRotation *= Quaternion.AngleAxis (rotateVelocity * turnInput * Time.deltaTime, Vector3.up); //Rotates on global Y axis.
		}
		transform.rotation = targetRotation;
	}

	/*void Animating(float h, float v){
		h = strafe.x;
		v = rBody.velocity.y;
		bool walking = v > 0f;
		bool walkingBackwards = v < 0f;
		bool walkingLeft = h < 0f;
		bool walkingRight = h >0f;
		anim.SetBool ("IsMoving", walking);
		anim.SetBool ("IsMovingBack", walkingBackwards);
		anim.SetBool ("IsMovingRight", walkingRight);
		anim.SetBool ("IsMovingLeft", walkingLeft);
	}*/

}
