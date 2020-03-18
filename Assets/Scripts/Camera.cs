using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    private float X;
    private float Y;

	// Use this for initialization
	void Start ()
    {
        X = 0f;
        Y = Player_1.PosiY();
    }
	
	// Update is called once per frame
	void Update ()
    {
        X = 0f;
        Y = Player_1.PosiY(); 

        Y = Mathf.Clamp(Y, -1f, 1f);

        this.transform.position= new Vector3(X, Y, -10);
    }
}
