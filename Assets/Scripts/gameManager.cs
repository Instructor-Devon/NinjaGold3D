using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public int Gold = 0;
    public string Verb;
    public string Building;
    public int nowGold;


    // singleton
    public static gameManager Instance
    {
        get
        {
            if (instance == null) instance = new GameObject("gameMangaer").AddComponent<gameManager>(); //create game manager object if required
            return instance;
        }
    }
    private static gameManager instance = null;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Awake()
    {
        if (instance)
            Destroy(gameObject); // delete any dupes
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject); //set as do not destroy
        }
    }
}
