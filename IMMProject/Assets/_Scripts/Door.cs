using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public AudioSource DoorOpen;

    void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(Inventory.keycard >= 1)
        {
            Destroy(gameObject);
            DoorOpen.Play();
        }
    }
}
