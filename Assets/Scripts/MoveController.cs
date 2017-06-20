using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {

    public IconController iconController;

    // Use this for initialization
    void Start()
    {
        iconController = GameObject.FindObjectOfType<IconController>();

    }
	
	// Update is called once per frame
	void Update () {
        Vector2 v2 = new Vector2(0, -.05f);

        transform.Translate(v2);
	}

}
