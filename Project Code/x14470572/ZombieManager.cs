using UnityEngine;
using System.Collections;

public class ZombieManager : MonoBehaviour {

	//public PlayerHealth playerHealth;
	public GameObject Zombie;
	public float spawnTime = 10f;
	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Spawn () 
	{
		//if(playerHealth.currentHealth <= 0f)
		//{
		//	return
		//}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		Instantiate (Zombie, spawnPoints [spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

	}
}
