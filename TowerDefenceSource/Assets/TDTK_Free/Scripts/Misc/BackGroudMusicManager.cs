using UnityEngine;
using System.Collections;

public class BackGroudMusicManager : MonoBehaviour {
	AudioSource audio;
	public AudioClip buildStage;
	public AudioClip level;
	public AudioClip gameOver;

	void Awake(){
		audio = GetComponent<AudioSource> ();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.gameState == _GameState.Idle) {
			audio.PlayOneShot(buildStage,0.8f);
		}
		if (GameControl.gameState == _GameState.Started) {
			//Debug.Log("idle");	
			audio.Stop ();
			audio.PlayOneShot(level, 0.8f);
		}

	}
}
