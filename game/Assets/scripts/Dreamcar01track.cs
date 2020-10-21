using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dreamcar01track : MonoBehaviour {
    public GameObject TheMarker;
    public GameObject mark01;
    public GameObject mark02;
    public GameObject mark03;
    public GameObject mark04;
    public GameObject mark05;
    public GameObject mark06;
    public GameObject mark07;
    public GameObject mark08;
    public GameObject mark09;
    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;
    public GameObject mark13;
    public GameObject mark14;
    public GameObject mark15;
    public int MarkTracker;

    void Update()
    {
        if (MarkTracker == 0)
        {
            TheMarker.transform.position = mark01.transform.position;
        }
        if (MarkTracker == 1)
        {
            TheMarker.transform.position = mark02.transform.position;
        }
        if (MarkTracker == 2)
        {
            TheMarker.transform.position = mark03.transform.position;
        }
        if (MarkTracker == 3)
        {
            TheMarker.transform.position = mark04.transform.position;
        }
        if (MarkTracker == 4)
        {
            TheMarker.transform.position = mark05.transform.position;
        }
        if (MarkTracker == 5)
        {
            TheMarker.transform.position = mark06.transform.position;
        }
        if (MarkTracker == 6)
        {
            TheMarker.transform.position = mark07.transform.position;
        }
        if (MarkTracker == 7)
        {
            TheMarker.transform.position = mark08.transform.position;
        }
        if (MarkTracker == 8)
        {
            TheMarker.transform.position = mark09.transform.position;
        }
        if (MarkTracker == 9)
        {
            TheMarker.transform.position = mark10.transform.position;
        }
        if (MarkTracker == 10)
        {
            TheMarker.transform.position = mark11.transform.position;
        }
        if (MarkTracker == 11)
        {
            TheMarker.transform.position = mark12.transform.position;
        }
        if (MarkTracker == 12)
        {
            TheMarker.transform.position = mark13.transform.position;
        }
        if (MarkTracker == 13)
        {
            TheMarker.transform.position = mark14.transform.position;
        }
        if (MarkTracker == 14)
        {
            TheMarker.transform.position = mark15.transform.position;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
            if (collision.gameObject.tag == "Dreamcar01") 
            {
                this.GetComponent<BoxCollider>().enabled = false;
                MarkTracker += 1;
                if (MarkTracker == 14)
                {
                    MarkTracker = 0;
                }
                yield return new WaitForSeconds(1);
                this.GetComponent<BoxCollider>().enabled = true;

            }
    }
}
