using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getTagText : MonoBehaviour {
    TextMesh nameTag;

	// Use this for initialization
	void Start () {
        nameTag = GetComponent<TextMesh>();
        if (transform.parent != null)
            nameTag.text = transform.parent.tag;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
