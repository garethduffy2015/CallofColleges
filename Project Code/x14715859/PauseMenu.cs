using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	

	public GameObject pausePanel;
	public bool isPaused;



	  void Start (){
		isPaused = false;

	}



	void Update (){
		if (isPaused) {
			PauseGame (true);
		} else {
			PauseGame (false);
		}

		if (Input.GetButtonDown ("Pause")) {
			SwitchPause ();
		}
	
	
	}

	void PauseGame(bool state){
		if (state) {
			
			Time.timeScale = 0.0f;
		} else {
			Time.timeScale = 1f;
			}

		pausePanel.SetActive (state);
	}

	public void SwitchPause(){
		if (isPaused) {
			isPaused = false;
		} else {
			isPaused = true;
		}
	}



}
