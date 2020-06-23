using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class eDisplayActivity : MonoBehaviour {

    private UnityAction displayActivity;
    public float waitSec = 2.0f;
    Text activityText;
    string activityStr;

    void Awake()
    {
        displayActivity = new UnityAction(UpdateActivityDisplay);
        activityText = GetComponent<Text>();
    }

    void Start()
    {
        activityText.enabled = false;
    }

    void OnEnable()
    {
        EventManager.StartListening("displayActivity", displayActivity);
    }

    void OnDisable()
    {
        EventManager.StopListening("displayActivity", displayActivity);
    }

    void UpdateActivityDisplay()
    {
        activityStr = "You " + gameManager.Instance.Verb + " " + gameManager.Instance.nowGold.ToString() + " from the " + gameManager.Instance.Building + "!";
        Debug.Log(activityStr);
        StartCoroutine("DisplayActivity");
    }

    IEnumerator DisplayActivity()
    {
        activityText.text = activityStr;
        activityText.enabled = true;
        yield return new WaitForSeconds(waitSec);
        activityText.enabled = false;
        activityText.text = "";
    }
}
