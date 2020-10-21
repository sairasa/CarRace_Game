using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour {

    public static int RaceMode;

    public void ScoreMode()
    {
        RaceMode = 1;
    }
    public void TimeMode()
    {
        RaceMode = 2;
    }
    public void TheRaceMode()
    {
        RaceMode = 0;
    }
}
