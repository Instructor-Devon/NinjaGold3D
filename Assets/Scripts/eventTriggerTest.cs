using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventTriggerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("q"))
        {
            EventManager.TriggerEvent("test");
        }
	}
}
