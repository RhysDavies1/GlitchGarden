using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float projectileSpeed;
	public float damage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.right * projectileSpeed * Time.deltaTime);
	
	}

}
