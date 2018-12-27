using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutScene : MonoBehaviour {

    public GameObject currentBox;
    public GameObject nextBox;
    public GameObject currentPic;
    public GameObject nextPic;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NEXTBOX()
    {
        print("aaaaah");
        nextBox.SetActive(true);
        currentBox.SetActive(false);

        currentPic.SetActive(false);
        nextPic.SetActive(true);
    }
}
