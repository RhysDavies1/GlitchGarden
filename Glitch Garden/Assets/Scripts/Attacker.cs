using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	[Range (-1f, 1.5f)]	
	public float currentSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
	
	}

	void OnTriggerEnter2D(){



	}

	public void SetSpeed (float speed){

		currentSpeed = speed;

	}

	public void StrikeCurrentTarget(float damage){

		Debug.Log ("Dealt " + damage + " damage!");

	}

}
