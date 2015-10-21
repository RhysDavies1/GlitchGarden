using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	public GameObject gunParent;

	private GameObject projectileParent;

	void Start (){

		projectileParent = GameObject.Find ("Projectiles");

		if (!projectileParent) {
		
			projectileParent = new GameObject ("Projectiles");
		
		}

	}

	private void FireGun(){

		if (projectileParent) {

			GameObject newProjectile = Instantiate (projectile) as GameObject;
			
			newProjectile.transform.parent = projectileParent.transform;

			newProjectile.transform.position = gunParent.transform.position;

		} else {
		
			Debug.LogError ("No Projectile parent game object found!");
		
		}


	}
}
