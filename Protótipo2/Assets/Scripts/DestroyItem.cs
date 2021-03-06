using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour {
	public GameObject player;
	public PickUpWeapon pickUp;

	public bool colliding;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		pickUp = player.GetComponent<PickUpWeapon> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (colliding == true && pickUp.crounch == true) {
			Destroy (gameObject);
			pickUp.crounch = false;
            pickUp.colliding = false;
            pickUp.collidingMK = false;
            pickUp.collidingWBL = false;
            pickUp.CanPickUp = false;
		}
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Player")
			colliding = true;
	}

	public void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.name == "Player")
			colliding = false;
	}
}
