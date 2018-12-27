using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door4 : MonoBehaviour {

   

    void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(Inventory.keycard >= 5)
        {
            Destroy(gameObject);

        }
    }
}
