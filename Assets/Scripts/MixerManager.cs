using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MixerManager : MonoBehaviour
{
    public Toggle tg1;
    public Toggle tg2;
    public Toggle tg3;
    public GameObject RoterPilz;
    public GameObject GrünerPilz;
    public GameObject GoldenerPilz;
    public GameObject Stern;


    private void Update()
    {
        if(tg1.isOn && tg2.isOn && tg3.isOn)
        {
            // Richtiger Code 
            RoterPilz.SetActive(false);
            GrünerPilz.SetActive(false);
            GoldenerPilz.SetActive(false);

            Stern.SetActive(true);
            
        }
    }
}
