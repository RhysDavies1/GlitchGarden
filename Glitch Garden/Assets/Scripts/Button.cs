using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	private Button[] buttonArray;

	public static GameObject selectedDefender;
	public GameObject defenderPrefab;

	void Start () {

		buttonArray = GameObject.FindObjectsOfType<Button> ();

	}

	void OnMouseDown (){

		foreach (Button thisButton in buttonArray) {
		
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;

		}

		GetComponent<SpriteRenderer> ().color = Color.white;

		selectedDefender = defenderPrefab;

	}



}
