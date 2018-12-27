using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endCutScene : MonoBehaviour {

    

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NEXT()
    {
        SceneManager.LoadScene("_cutScene2");
    }
}
