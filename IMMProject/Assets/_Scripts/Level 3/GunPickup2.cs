using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup2 : MonoBehaviour {


    public AudioSource Pickup1;

	
	void Start () {
		
	}
	
	void Update () {
		



	}

    private void OnTriggerEnter(Collider other)
    {

        Pickup1.Play();

        Inventory.guns += 3;
        this.gameObject.SetActive(false);
    }
}
