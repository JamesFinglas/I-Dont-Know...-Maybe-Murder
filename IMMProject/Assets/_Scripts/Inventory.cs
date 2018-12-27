using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//###########################################################################################################################################################################
//  This Code was pretty much all original , the only thing that we took from Jimmy Vegas' tutorial was the "EquipHandgun" thing. It's an input name for when we press 1
//###########################################################################################################################################################################

public class Inventory : MonoBehaviour
{

    public static int guns = 0;
    public static int health = 100;
    public static int keycard = 0;
    public GameObject HandGun;
    public GameObject ShotGun;
    public GameObject Rifle;
    public GameObject Health;
    public GameObject HGAmmoDisplay;
    public GameObject HGLoadedDisplay;
    public GameObject SGAmmoDisplay;
    public GameObject SGLoadedDisplay;
    public GameObject MGAmmoDisplay;
    public GameObject MGLoadedDisplay;






    public void Update()
    {
        Health.GetComponent<Text>().text = "" + health;
        if (Input.GetButtonDown("EquipHandgun") && guns >=  1)
        {
            
            ShotGun.SetActive(false);
            Rifle.SetActive(false);
            HandGun.SetActive(true);
        }

        if (Input.GetButtonDown("EquipShotgun") && guns >1)
        {
            
            
            Rifle.SetActive(false);
            HandGun.SetActive(false);
            ShotGun.SetActive(true);
        }

        if (Input.GetButtonDown("EquipRifle") && guns > 2)
        {
            
            HandGun.SetActive(false);
            ShotGun.SetActive(false);
            Rifle.SetActive(true);
            

        }

        if(health <= 0)
        {
            
            
            health = 100;
            keycard = 0;

            GlobalAmmo.HGCurrentAmmo = 0;
            GlobalAmmo.HGLoadedAmmo = 0;

            HGAmmoDisplay.GetComponent<Text>().text = "" + GlobalAmmo.HGInternalAmmo;
            HGLoadedDisplay.GetComponent<Text>().text = "" + GlobalAmmo.HGLoadedAmmo;

            GlobalAmmo.SGCurrentAmmo = 0;
            GlobalAmmo.SGLoadedAmmo = 0;

            SGAmmoDisplay.GetComponent<Text>().text = "" + GlobalAmmo.SGInternalAmmo;
            SGLoadedDisplay.GetComponent<Text>().text = "" + GlobalAmmo.SGLoadedAmmo;

            GlobalAmmo.MGCurrentAmmo = 0;
            GlobalAmmo.MGLoadedAmmo = 0;

            MGAmmoDisplay.GetComponent<Text>().text = "" + GlobalAmmo.MGInternalAmmo;
            MGLoadedDisplay.GetComponent<Text>().text = "" + GlobalAmmo.MGLoadedAmmo;

            SceneManager.LoadScene("_levelOne");

        }

        

    }

}

