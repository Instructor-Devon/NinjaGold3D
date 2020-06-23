using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building : MonoBehaviour {

	// Use this for initialization
	void Start () {
        EventManager.TriggerEvent("goldAquired");
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        ProcessGold(gameObject.tag);
        
    }
    void ProcessGold(string building)
    {
        int thisGold;
        gameManager.Instance.Building = building;
        if (building != "Casino")
            gameManager.Instance.Verb = "Earned";
        if (building == "Farm")
        {
            thisGold = Random.Range(20, 31);
        }
        else if (building == "House")
        {
            thisGold = Random.Range(3, 9);

        }
        else if (building == "Cave")
        {
            thisGold = Random.Range(2, 5);

        }
        else
        {
            thisGold = Random.Range(-100, 100);
            if (thisGold < 0)
                gameManager.Instance.Verb = "Lost";
            else
                gameManager.Instance.Verb = "Earned";

        }
        // add gold b/t 20 - 30
        gameManager.Instance.Gold += thisGold;
        gameManager.Instance.nowGold = Mathf.Abs(thisGold);
        EventManager.TriggerEvent("goldAquired");
        EventManager.TriggerEvent("displayActivity");
    }
}
