using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cancelInvoke : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider e)
    {
        if (e.tag == "Player")
        {
            CancelInvoke();
        }
    }
}
