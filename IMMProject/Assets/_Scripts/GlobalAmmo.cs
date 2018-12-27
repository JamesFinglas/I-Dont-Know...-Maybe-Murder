using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//###################################################################################################################################
// Tutorial used for this script, C/O Jimmy Vegas https://www.youtube.com/watch?v=0fGB2H1AGP8&list=PLZ1b66Z1KFKh-auyvzNkOBFLWf6dH6iEH
// Its a basic tutorial that taught me how to make health for enemies, shoot guns , ammo and ammo pickups.

// Using his code i made my own "Shotgun and Machinegun" Weapons with different damages and ranges.
//###################################################################################################################################

public class GlobalAmmo : MonoBehaviour {

    // Handgun

    public static int HGCurrentAmmo;
    public static int HGInternalAmmo;
    public GameObject HGAmmoDisplay;

    public static int HGLoadedAmmo;
    public static int HGInternalLoaded;
    public GameObject HGLoadedDisplay;

    // Shotgun

    public static int SGCurrentAmmo;
    public static int SGInternalAmmo;
    public GameObject SGAmmoDisplay;

    public static int SGLoadedAmmo;
    public static int SGInternalLoaded;
    public GameObject SGLoadedDisplay;

    // Machinegun

    public static int MGCurrentAmmo;
    public static int MGInternalAmmo;
    public GameObject MGAmmoDisplay;

    public static int MGLoadedAmmo;
    public static int MGInternalLoaded;
    public GameObject MGLoadedDisplay;



    void Start ()
    {
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
    } 
	
	void Update ()
    {
        HGInternalAmmo = HGCurrentAmmo;
        HGInternalLoaded = HGLoadedAmmo;
        HGAmmoDisplay.GetComponent<Text>().text = "" + HGInternalAmmo;
        HGLoadedDisplay.GetComponent<Text>().text = "" + HGLoadedAmmo;

        SGInternalAmmo = SGCurrentAmmo;
        SGInternalLoaded = SGLoadedAmmo;
        SGAmmoDisplay.GetComponent<Text>().text = "" + SGInternalAmmo;
        SGLoadedDisplay.GetComponent<Text>().text = "" + SGLoadedAmmo;

        MGInternalAmmo = MGCurrentAmmo;
        MGInternalLoaded = MGLoadedAmmo;
        MGAmmoDisplay.GetComponent<Text>().text = "" + MGInternalAmmo;
        MGLoadedDisplay.GetComponent<Text>().text = "" + MGLoadedAmmo;
    }
}
