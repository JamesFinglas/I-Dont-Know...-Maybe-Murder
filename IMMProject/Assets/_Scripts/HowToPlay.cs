using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour {

    public GameObject Title;
    public GameObject StartGame;
    public GameObject How2Play;
    public GameObject h2p1;
    public GameObject h2p2;

    public void Instructions()
    {
        Title.SetActive(false);
        StartGame.SetActive(false);
        How2Play.SetActive(false);

        h2p1.SetActive(true);
        h2p2.SetActive(true);




    }

    public void back()
    {
        Title.SetActive(true);
        StartGame.SetActive(true);
        How2Play.SetActive(true);

        h2p1.SetActive(false);
        h2p2.SetActive(false);

    }
}
