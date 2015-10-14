using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	private AudioSource loadSound;

	void Awake (){

		DontDestroyOnLoad (gameObject);

	}

	void Start(){
		
		loadSound = GameObject.Find ("LoadSound").GetComponent<AudioSource> ();
		
		loadSound.volume = PlayerPrefsManager.GetMasterVolume ();
	
		audioSource = GetComponent<AudioSource> ();

		audioSource.volume = PlayerPrefsManager.GetMasterVolume ();
			
	}

	void OnLevelWasLoaded (int level) {

		AudioClip thisLevelMusic = levelMusicChangeArray [level];

		if (thisLevelMusic)
		{

			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();

		}

	}

	public void ChangeVolume(float volumeSlider){

		audioSource.volume = volumeSlider;

	}

}
