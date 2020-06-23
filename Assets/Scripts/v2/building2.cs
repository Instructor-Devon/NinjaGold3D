using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building2 : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {
        goldEvents.onGoldAquired += processGold;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }

    void Destroy()
    {
        goldEvents.onGoldAquired -= processGold;
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        processGold(tag);

    }

    public void processGold(string building)
    {
        int thisGold;
        string thisVerb = "earned";
        if (building != "Casino")
            thisVerb = "Earned";
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
                thisVerb = "lost";
            else
                thisVerb = "earned";

        }
        // add gold b/t 20 - 30
        gameManager.Instance.Gold += thisGold;
        goldEvents.displayGold(gameManager.Instance.Gold);
        goldEvents.displayMessage(thisVerb, Mathf.Abs(thisGold), building);
    }
   
}
