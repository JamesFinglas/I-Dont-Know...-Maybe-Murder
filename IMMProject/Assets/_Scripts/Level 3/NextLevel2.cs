using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider e)
    {
        if(e.tag == "Player")
        {
            //SceneManager.LoadScene("_levelThree"); GAME OVER
        }
    }
}
