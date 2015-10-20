using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health;

	// Update is called once per frame
	void Update () {

		if (health <= 0) {

			//Optionally trigger animation for death
		
			DestroyObject();
		
		}
	
	}

	public void TakeDamage(float damage){

		health -= damage;

	}

	public void DestroyObject() {

		Destroy (gameObject);

	}

}
