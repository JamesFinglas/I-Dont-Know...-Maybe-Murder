using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : MonoBehaviour {


    public AudioSource Pickup;

	
	void Start () {
		
	}
	
	void Update () {
		



	}

    private void OnTriggerEnter(Collider other)
    {

        Pickup.Play();

        Inventory.guns += 1;
        this.gameObject.SetActive(false);
    }
}
