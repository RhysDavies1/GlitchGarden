using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	public Camera myCamera;

	private GameObject defenderParent;
	
	void Start (){
		
		defenderParent = GameObject.Find ("Defenders");
		
		if (!defenderParent) {
			
			defenderParent = new GameObject ("Defenders");
			
		}
		
	}

	void OnMouseDown(){

		if (defenderParent) {

			Vector2 rawPos = CalculateWorldPointOfMouseClick ();
			Vector2 roundedPos = SnapToGrid (rawPos);

			GameObject newDefender = Instantiate (Button.selectedDefender, roundedPos, Quaternion.identity) as GameObject;

			newDefender.transform.parent = defenderParent.transform;

		} else {
			
			Debug.LogError ("No defender parent gameobject found!");
			
		}
	}

	Vector2 SnapToGrid (Vector2 rawWorldPos){

		float newX = Mathf.RoundToInt (rawWorldPos.x);
		float newY = Mathf.RoundToInt (rawWorldPos.y);
				
		return new Vector2 (newX, newY);
	}

	Vector2 CalculateWorldPointOfMouseClick(){

		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;
		float distanceFromCamera = 10f;

		Vector3 weirdTriplet = new Vector3 (mouseX, mouseY, distanceFromCamera);

		Vector2 worldPos = myCamera.ScreenToWorldPoint (weirdTriplet);

		return worldPos;

	}
}
