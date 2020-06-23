using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class eGoldAquired : MonoBehaviour {

    private UnityAction updateGoldListener;
    Text goldText;

    void Awake()
    {
        updateGoldListener = new UnityAction(UpdateGoldDisplay);
        goldText = GetComponent<Text>();
    }

    void OnEnable()
    {
        EventManager.StartListening("goldAquired", updateGoldListener);
    }
    void OnDisable()
    {
        EventManager.StopListening("goldAquired", updateGoldListener);
    }

    void UpdateGoldDisplay()
    {
        goldText.text = "Gold: " + gameManager.Instance.Gold.ToString();
    }
}
