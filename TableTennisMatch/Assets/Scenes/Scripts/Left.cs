using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Right
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.left * 0.5f);
        }

        //Motion Left
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.right * 0.5f);
        }

        //Up
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.up * 0.5f);
        }

        //Down
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.down * 0.5f);
        }

        //Forward
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Translate(Vector3.left * 0.5f);
        }

        //Back
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Translate(Vector3.right * 0.5f);
        }


    }
}
