using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fader : MonoBehaviour {

	public float faderTime;

	private Image fader;
	private Color currentColor;

	void Start () {

		fader = GetComponent<Image> ();

		currentColor = fader.color;

	}

	void Update (){
	
		if (Time.timeSinceLevelLoad < faderTime) {
		
			float alphaChange = Time.deltaTime / faderTime;

			currentColor.a -= alphaChange;

			fader.color = currentColor;
		
		} else {
		
			gameObject.SetActive (false);

		}
	
	}
	
}
