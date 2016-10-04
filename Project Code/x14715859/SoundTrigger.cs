using UnityEngine;
using System.Collections;

public class SoundTrigger : MonoBehaviour {
	public AudioSource source;

	public void Awake(){
		source = GetComponent<AudioSource>();
	
	}

	public void OnTriggerEnter(Collider other){
		source.Play ();
	}
}
