using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldDisplay : MonoBehaviour {

    string goldToDisplay;

	// Use this for initialization
	void Start () {
        goldToDisplay = GetComponent<Text>().text;
	}
	
	void Awake () {
		
	}
}
