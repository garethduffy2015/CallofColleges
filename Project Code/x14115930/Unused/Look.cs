using UnityEngine;
using System.Collections;

public class Look : MonoBehaviour {

	public Transform target; 

	void  Update (){
		transform.LookAt(target);
	}
}
