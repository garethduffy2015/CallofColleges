using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform target; //User can set the cameras target.
	public float smoothing = 0.09f; //User can set hoe smooth the camera moves.
	public Vector3 offset = new Vector3(0, 6, -8); //User can set the distance between the player and the camera.
	public float xTilt = 10; //User can set the cameras x axis tilt.

	Vector3 destination = Vector3.zero; //Where the camera will move to.
	CharacterController charController; //Used to access the target rotation of the character.
	float rotateVelocity = 0;

	void Start(){
		SetCameraTarget (target);
	}

	void SetCameraTarget(Transform t){ //Allows user to set the camera a new target to look at.
		target = t;

		if (target != null) { //If target is not equal to null then get target controller.
			if(target.GetComponent<CharacterController>()){
				charController = target.GetComponent<CharacterController>();
			}
			else //If target controller is not available then show messsage.
				Debug.LogError("There is no Character Controller Script.");
		}
		else //If target is equal to null then show message.
			Debug.LogError("You need to set your camera a target.");	
	}

	void LateUpdate(){
		MoveToTarget(); //Moving.
		LookAtTarget(); //Rotating.
	}

	void MoveToTarget(){ //Moves the camera behind the target.
		destination = charController.TargetRotation * offset;
		destination += target.position; //Checks to see if destination is relative to target.
		transform.position = destination;
	}

	void LookAtTarget(){
		float eulerYAngle = Mathf.SmoothDampAngle (transform.eulerAngles.y, target.eulerAngles.y, ref rotateVelocity, smoothing);
		transform.rotation = Quaternion.Euler (transform.eulerAngles.x, eulerYAngle, 0);
	}

}
