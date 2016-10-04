using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

	public Animator anim;
	public KeyCode Forward;
	public KeyCode Back;
	public KeyCode Left;
	public KeyCode Right;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(Forward)) {
			anim.SetBool ("playerForward", true);
			anim.SetBool ("playerBackward", false);
			anim.SetBool ("playerLeft", false);
			anim.SetBool ("playerRight", false);
			anim.SetBool ("playerIdle", false);
		} else if (Input.GetKey (Back)) {
			anim.SetBool ("playerBackward", true);
			anim.SetBool ("playerForward", false);
			anim.SetBool ("playerLeft", false);
			anim.SetBool ("playerRight", false);
			anim.SetBool ("playerIdle", false);
		} else if (Input.GetKey (Left)) {
			anim.SetBool ("playerLeft", true);
			anim.SetBool ("playerForward", false);
			anim.SetBool ("playerBackward", false);
			anim.SetBool ("playerRight", false);
			anim.SetBool ("playerIdle", false);
		} else if (Input.GetKey (Right)) {
			anim.SetBool ("playerRight", true);
			anim.SetBool ("playerLeft", false);
			anim.SetBool ("playerForward", false);
			anim.SetBool ("playerBackward", false);
			anim.SetBool ("playerIdle", false);
		} else {
			anim.SetBool ("playerForward", false);
			anim.SetBool ("playerBackward", false);
			anim.SetBool ("playerLeft", false);
			anim.SetBool ("playerRight", false);
			anim.SetBool ("playerIdle", true);
		}
	}

	/*void Animating(){
		bool walking = Input.GetKey (Forward);
		bool walkingBackwards = Input.GetKey (Back);
		bool walkingLeft = Input.GetKey (Left);
		bool walkingRight = Input.GetKey (Right);
		anim.SetBool ("playerForward", walking);
		anim.SetBool ("playerBackward", walkingBackwards);
		anim.SetBool ("playerRight", walkingRight);
		anim.SetBool ("playerLeft", walkingLeft);
	}*/
}
