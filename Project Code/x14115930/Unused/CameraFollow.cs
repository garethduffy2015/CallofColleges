using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing = 5f;
	public float xOffset = 5f;

	Vector3 offset;


	void Start(){
		offset = transform.position - target.position;
	}

	void FixedUpdate(){
		Vector3 targetCamPos = target.position + offset;
		Vector3 current = new Vector3 (transform.position.x + xOffset, transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp (current, targetCamPos, smoothing * Time.deltaTime);
	}

}
