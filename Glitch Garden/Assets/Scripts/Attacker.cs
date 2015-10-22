using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]

public class Attacker : MonoBehaviour {


	private float currentSpeed;
	private GameObject currentTarget;

	private Animator animator;

	private Health healthTarget;


	void Start () {

		animator = GetComponent<Animator> ();

	}

	void Update () {

		//movement
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);

		//no target, no attack!
		if (!currentTarget) {
		
			animator.SetBool ("isAttacking", false);
		
		}

	}


	public void SetSpeed (float speed){

		currentSpeed = speed;

	}

	public void Attack (GameObject obj) {

		currentTarget = obj;

	}
		
	public void StrikeCurrentTarget(float damage){

		healthTarget = currentTarget.GetComponent<Health> ();

		if (currentTarget) {


				if (healthTarget){
					healthTarget.TakeDamage(damage);
				}

		}
		
	}

}
