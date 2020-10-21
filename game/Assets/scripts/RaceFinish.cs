using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {
    public GameObject MyCar;
    public GameObject FinishCam;
    public GameObject ViewModes;
    public GameObject CompleteTrig;
    // public GameObject LevelMusic;

    void OnTriggerEnter()
    {
        if (ModeTime.isTimeMode == true)
        {

        }
        else
        {
            MyCar.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            MyCar.GetComponent<CarController>().enabled = false;
            MyCar.GetComponent<CarUserControl>().enabled = false;
            MyCar.SetActive(true);
            FinishCam.SetActive(true);
            // LevelMusic.SetActive(false);
            ViewModes.SetActive(false);
        }
      
    }


}
