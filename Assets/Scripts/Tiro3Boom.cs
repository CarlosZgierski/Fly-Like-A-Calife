using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro3Boom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Destroy(gameObject, 4);	
	}
}
