using UnityEngine;
using System.Collections;

public class ZombieMovement : MonoBehaviour 
{
	Transform player;
	//PlayerHealth playerHealth;
	//ZombieHealth zombieHealth;
	NavMeshAgent nav;
	public float zombieSpeed = 450f;


	// Use this for initialization
	void Awake () 
	{
		player = GameObject.FindWithTag ("Player").transform;
		//playerHealth = player.GetComponent <PlayerHealth> ();
		//zombieHealth = GetComponent <ZombieHealth> ();
		nav = GetComponent <NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
		//{
		nav.SetDestination(player.position);
		nav.speed = zombieSpeed;
		//}
		//else
		//{
			//nav.enabled = false;
		//}
	}
}
