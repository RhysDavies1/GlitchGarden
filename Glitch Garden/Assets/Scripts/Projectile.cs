using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float projectileSpeed;
	public float damage;

	void Update () {

		transform.Translate (Vector3.right * projectileSpeed * Time.deltaTime);
	
	}

	void OnTriggerEnter2D (Collider2D collider){

		GameObject obj = collider.gameObject;

		Health health = obj.gameObject.GetComponent<Health> ();

		Attacker attacker = obj.gameObject.GetComponent<Attacker> ();

		if (attacker && health) {
		
			health.TakeDamage (damage);

			Destroy (gameObject);
		
		} else {
		
			return;
		
		}


	}

}
