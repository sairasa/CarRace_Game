using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditfinish : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(CreditEnd());
	}
	
	IEnumerator CreditEnd()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
