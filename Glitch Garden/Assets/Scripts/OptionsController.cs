using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;

	private MusicManager musicManager;

	// Use this for initialization
	void Start () {

		musicManager = GameObject.FindObjectOfType<MusicManager> ();

		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();

		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
	
	}

	void Update () {

		if (musicManager) {
			musicManager.ChangeVolume (volumeSlider.value);
		}

	}
	
	public void SavePrefs(){

		int difficulty = Mathf.RoundToInt (difficultySlider.value);

		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (difficulty);

	}

	public void SetDefaults(){

		volumeSlider.value = 1f;
		difficultySlider.value = 2f;

		SavePrefs ();

	}
}
