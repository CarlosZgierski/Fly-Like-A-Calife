using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaninng : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
