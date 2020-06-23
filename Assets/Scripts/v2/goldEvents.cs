using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldEvents : MonoBehaviour {

    public delegate void GoldHandler(string building);
    public delegate void DisplayGoldHandler(int goldToDisplay);
    public delegate void DisplayMessageHandler(string verb, int gold, string building);

    public static event GoldHandler onGoldAquired;
    public static event DisplayGoldHandler onDisplayGold;
    public static event DisplayMessageHandler onDisplayMessage;

    public static void processGold(string building)
    {
        if (onGoldAquired != null)
            onGoldAquired(building);
    }
    public static void displayGold(int goldToDisplay)
    {
        if (onDisplayGold != null)
            onDisplayGold(goldToDisplay);
    }

    public static void displayMessage(string verb, int gold, string building)
    {
        if (onDisplayMessage != null)
            onDisplayMessage(verb, gold, building);
    }
	
}
